using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Firefly.Box;
using Firefly.Box.UI.Advanced;
using ENV;
using ENV.Data;

namespace $rootnamespace$.Views
{
    partial class $safeitemname$View : Shared.Theme.Controls.Form
    {
        $safeitemname$ _controller;
        public $safeitemname$View($safeitemname$ controller)
        {
            _controller = controller; 
            InitializeComponent();
        }
    }
}