using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Firefly.Box;
using ENV;
using ENV.Data;
using ENV.Printing;

namespace $rootnamespace$
{
    public class $safeitemname$ : BusinessProcessBase
    {
        PrinterWriter _printer;
        Printing.$safeitemname$Layout _layout => Cached<Printing.$safeitemname$Layout>(); 

        public $safeitemname$()
        {

        }

        protected override void OnLoad()
        {
            _printer = new PrinterWriter{PrintPreview = true};
            Streams.Add(_printer);
        }

        protected override void OnLeaveRow()
    	{
	        _layout.Body.WriteTo(_printer);
        }

        public void Run()
        {
            Execute();
        }
    }
}