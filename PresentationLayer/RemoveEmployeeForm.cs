using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class RemoveEmployeeForm : Form, IRemoveEmployeeView
    {
        private readonly IMainController _controller;


        public RemoveEmployeeForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormRemoveEmployee_Load(object sender, EventArgs e)
        {
            var employees = _controller.GetAllEmployees();
            foreach (var employee in employees)
            {
                cbxEmployee.Items.Add(employee);
            }
        }

        private void ButtonRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (cbxEmployee.SelectedIndex != -1)
            {
                var repairsSomeWall = _controller.DoesEmployeeRepairSomeWall(this);
                if (repairsSomeWall)
                {
                    var dialogResult = MessageBox.Show(@"Employee assigned to a video wall. Really remove?",
                        @"Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _controller.RemoveEmployee(this);
                        Close();
                    }
                }
                else
                {
                    _controller.RemoveEmployee(this);
                }

                Close();
            }
            else
            {
                MessageBox.Show(@"No employee selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public Employee EmployeeData => (Employee)cbxEmployee.SelectedItem;
    }
}