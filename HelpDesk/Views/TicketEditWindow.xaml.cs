using HelpDesk.Models;
using System;
using System.Windows;

namespace HelpDesk.Views
{
    public partial class TicketEditWindow : Window
    {
        private Ticket _ticket;

        public TicketEditWindow(Ticket selectedTicket)
        {
            InitializeComponent();

            _ticket = selectedTicket;

            IdTextBlock.Text = $"Заявка №: {_ticket.Id}";
            DescriptionTextBox.Text = _ticket.Description;
            CategoryComboBox.Text = _ticket.Category;
            PriorityComboBox.Text = _ticket.Priority;
            StatusComboBox.Text = _ticket.Status;
        }
    }
}
