using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ViewEmployeesForm : Form, IShowView<Employee>
    {
        private IMainController _controller;
        private IList<Employee> _employees;

        public ViewEmployeesForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        public void ShowModal(IMainController inMainController, IList<Employee> employees)
        {
            _controller = inMainController;
            _employees = employees;

            UpdateList();
            ShowDialog();
        }

        private void FormViewEmployees_Load(object sender, EventArgs e)
        {
        }

        private void UpdateList()
        {
            listEmployees.Items.Clear();

            foreach (var employee in _employees)
            {
                var listViewItem = new ListViewItem(employee.Oib);
                listViewItem.SubItems.Add(employee.Surname);
                listViewItem.SubItems.Add(employee.Name);

                listEmployees.Items.Add(listViewItem);
            }
        }


        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            _controller.ShowAddEmployee();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateView()
        {
            _employees = _controller.GetAllEmployees();
            UpdateList();
        }
    }
}