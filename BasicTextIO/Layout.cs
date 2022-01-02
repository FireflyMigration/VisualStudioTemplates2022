using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Firefly.Box;
using ENV;
using ENV.Data;

namespace $rootnamespace$.TextIO
{
    partial class $safeitemname$Layout : Shared.Theme.TextIO.TextLayout
    {
        $safeitemname$ _controller;
        public $safeitemname$Layout($safeitemname$ controller):base(controller)
        {
            _controller = controller; 
            InitializeComponent();
        }
    }
}