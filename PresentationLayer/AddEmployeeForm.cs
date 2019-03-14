using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddEmployeeForm : Form, IAddEmployeeView
    {
        private readonly IMainController _controller;

        public AddEmployeeForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddEmployee(this);
                Close();
            }
            catch (Exception ex) when (ex is InvalidPersonDataException ||
                                       ex is EmployeeWithOibAlreadyExistsException)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        string IAddEmployeeView.Oib => tbxEmployeeOib.Text;
        string IAddEmployeeView.Surname => tbxEmployeeSurname.Text;
        string IAddEmployeeView.Name => tbxEmployeeName.Text;
    }
}