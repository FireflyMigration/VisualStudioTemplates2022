using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Firefly.Box;
using ENV;
using ENV.Data;

namespace $rootnamespace$
{
    public class $safeitemname$ : UIControllerBase
    {
        
        public $safeitemname$()
        {
            
        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = ()=> new Views.$safeitemname$View(this);
        }
    }
}