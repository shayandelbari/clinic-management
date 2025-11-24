using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagement_proj.UI
{
    /// <summary>
    /// Controller for the Doctor Scheduling panel
    /// </summary>
    public class SchedulingController : IPanelController
    {
        private readonly Panel panel;
        private GroupBox grpScheduling => (GroupBox)panel.Controls["grpDoctorScheduling"];
        private TableLayoutPanel schedulingLayout => (TableLayoutPanel)grpScheduling.Controls["layoutSchedulingContent"];
        private ListBox lbSunday => (ListBox)schedulingLayout.Controls["lbSunday"];
        private ListBox lbMonday => (ListBox)schedulingLayout.Controls["lbMonday"];
        private ListBox lbTuesday => (ListBox)schedulingLayout.Controls["lbTuesday"];
        private ListBox lbWednesday => (ListBox)schedulingLayout.Controls["lbWednesday"];
        private ListBox lbThursday => (ListBox)schedulingLayout.Controls["lbThursday"];
        private ListBox lbFriday => (ListBox)schedulingLayout.Controls["lbFriday"];
        private ListBox lbSaturday => (ListBox)schedulingLayout.Controls["lbSaturday"];

        public Panel Panel => panel;

        public SchedulingController(Panel panel)
        {
            this.panel = panel;
        }

        public void Initialize()
        {
            SetupSchedulingListViews();
        }

        public void OnShow()
        {
            RefreshSchedulingListViews();
        }

        /// <summary>
        /// Refresh the scheduling list views to adapt to window size changes
        /// </summary>
        public void RefreshSchedulingListViews()
        {
            List<ListBox> dayListBoxes = new List<ListBox>
            {
                lbSunday, lbMonday, lbTuesday, lbWednesday,
                lbThursday, lbFriday, lbSaturday
            };

            foreach (ListBox lb in dayListBoxes)
            {
                if (lb.Items.Count != 24)
                {
                    lb.Items.Clear();
                    for (int i = 0; i < 24; i++)
                    {
                        lb.Items.Add("");
                    }
                }

                lb.ItemHeight = lb.ClientSize.Height / 24;
            }
        }

        /// <summary>
        /// Setup the scheduling list views with custom drawing
        /// </summary>
        private void SetupSchedulingListViews()
        {
            List<ListBox> dayListBoxes = new List<ListBox>
            {
                lbSunday, lbMonday, lbTuesday, lbWednesday,
                lbThursday, lbFriday, lbSaturday
            };

            RefreshSchedulingListViews();

            foreach (ListBox lb in dayListBoxes)
            {
                lb.DrawItem += (s, e) =>
                {
                    e.DrawBackground();

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds);
                    else
                        e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);

                    e.Graphics.DrawRectangle(Pens.Gray, e.Bounds);
                };
            }
        }

        public void OnHide()
        {
            // Cleanup when leaving panel
        }

        public void Cleanup()
        {
            // Dispose resources if needed
        }
    }
}
