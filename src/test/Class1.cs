using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Test
    {
	    public void TestMe()
	    {
		    var something = true;
		    var somethingElse = false;
		    if (something && somethingElse)
		    {
			    something = false;
				TestMe();
		    }
		    throw new Exception("hello");
	    }
    }
}
