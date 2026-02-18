using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace unitconverterA
{
    public class InchToMM : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the InchToMM class.
        /// </summary>
        public InchToMM()
          : base("InchToMMConvertor", "IM",
              "Converts Millimeter to Inch",
              "UnitConvertor1", "Utilities")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Inches", "IN", "Converted values in inches", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Millimeters", "MM", "Input Values in Millimeters", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double Inches = 0.0;
            if (!DA.GetData(0, ref Inches)) return;

            double mm = Inches * 25.4;

            DA.SetData(0, mm);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("1A39105A-1705-4EF4-A666-BBAD6AF9A5E4"); }
        }
    }
}