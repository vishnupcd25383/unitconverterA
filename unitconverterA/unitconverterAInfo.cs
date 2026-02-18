using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace unitconverterA
{
    public class unitconverterAInfo : GH_AssemblyInfo
    {
        public override string Name => "unitconverterA";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("219d663c-9781-4f1a-8c29-fe3df616bc99");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}