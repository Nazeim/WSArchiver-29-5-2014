using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Common.Search;

namespace WSArchiver.GUI.UserControls
{
    public partial class DateRangeSearchControl : SearchControl
    {
        public DateRangeSearchControl()
        {
            InitializeComponent();
        }

        public DateRangeSearchControl(Library.Common.Search.Filter.FilterEnum filter)
            : base(filter)
        {
            InitializeComponent();
        }
        private void SetEndMinValue()
        {
            endDTP.MinDate = startDTP.Value;
        }

        protected override object GenerateCriteria()
        {
            return GenerateDateRange();
        }

        private void startDTP_ValueChanged(object sender, EventArgs e)
        {
            SetEndMinValue();
        }

        private void DateRangeSearchControl_Load(object sender, EventArgs e)
        {
            SetEndMinValue();
        }


        public DateRange GenerateDateRange()
        {
            if (startDTP.Value == endDTP.Value)
                return new DateRange(startDTP.Value);

            return new DateRange(startDTP.Value, endDTP.Value);
        }
    }
}
