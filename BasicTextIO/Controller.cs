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
        ENV.IO.FileWriter _fileWriter;
        TextIO.$safeitemname$Layout _layout => Cached<TextIO.$safeitemname$Layout>();

        public $safeitemname$()
        {

        }

        protected override void OnLoad()
        {
            _fileWriter = new ENV.IO.FileWriter("$safeitemname$.txt");
            Streams.Add(_fileWriter);
        }

        protected override void OnLeaveRow()
    	{
	        _layout.Body.WriteTo(_fileWriter);
        }

        public void Run()
        {
            Execute();
        }
    }
}