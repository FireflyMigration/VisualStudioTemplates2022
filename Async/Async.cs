using System;
using System.Collections.Generic;
using System.Text;
using Firefly.Box;
using ENV.Data;

namespace $rootnamespace$
{
    public class $safeitemname$:AsyncHelperBase
    {
        public $safeitemname$()
        {
            DisableApplicationStart = true;
            CopyParametersInMemory = true;
        }
        public void Run()
        {
            RunAsync<TheController>(t => t.Run());
        }
    }
}