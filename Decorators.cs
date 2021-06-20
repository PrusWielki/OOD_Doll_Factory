using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Retake_1
{
    abstract class Decorator : ConsoleApplication1.IToy
    {
        protected ConsoleApplication1.IToy _component;

        public Decorator(ConsoleApplication1.IToy component)
        {
            this._component = component;
        }

        public void SetComponent(ConsoleApplication1.IToy component)
        {
            this._component = component;
        }


        virtual public float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost();
            }
            else
            {
                return -1;
            }
        }

        virtual public string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary();
            }
            else
            {
                return String.Empty;
            }
        }

        public float Height()
        {
            if (this._component != null)
            {
                return this._component.Height();
            }
            else
            {
                return -1;
            }
        }
    }


    class Sword : Decorator
    {
      
        public Sword(ConsoleApplication1.IToy component):base(component)
        {
            
        }
   


        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost()+15;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary()+ "I have a sword!";
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class Helmet : Decorator
    {

        public Helmet(ConsoleApplication1.IToy component) : base(component)
        {

        }



        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost() + 10;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary()+ "I have a helmet on my head!";
            }
            else
            {
                return String.Empty;
            }
        }
    }
    abstract class Dress : Decorator
    {

        public Dress(ConsoleApplication1.IToy component) : base(component)
        {

        }



        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost();
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary();
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class FlowerDress : Dress
    {

        public FlowerDress(ConsoleApplication1.IToy component) : base(component)
        {

        }



        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost() + 20;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary() + "I have a flower dress";
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class DottedDress : Dress
    {

        public DottedDress(ConsoleApplication1.IToy component) : base(component)
        {

        }



        public override float Cost()
        {
            if (this._component != null)
            {
                return (float)(this._component.Cost() + 19.99);
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary() + "I have a dotted dress";
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class Jump : Decorator
    {

        double times = 5;
        public Jump(ConsoleApplication1.IToy component) : base(component)
        {
          
        }
     


        public override float Cost()
        {
            if (this._component != null)
            {
                return (float)(this._component.Cost() + 20);
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                if (times > 0)
                {
                    string toreturn = this._component.Summary() + $"I can jump! I just jumped {_component.Height() * (double)(times/10.0)} cm!";

                    times -= 1;
                    return toreturn;
                }
                else
                    return this._component.Summary();


            }
            else
            {
                return String.Empty;
            }
        }
    }
    abstract class Dances : Decorator
    {

        public Dances(ConsoleApplication1.IToy component) : base(component)
        {

        }

        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost();
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary();
            }
            else
            {
                return String.Empty;
            }
        }
    }

    class BreakDanceDance : Dances
    {

        public BreakDanceDance(ConsoleApplication1.IToy component) : base(component)
        {

        }


        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost()+50;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary()+ "I can dance BreakDance ";
            }
            else
            {
                return String.Empty;
            }
        }
    }

    class SoloCapoeiraDance : Dances
    {

        public SoloCapoeiraDance(ConsoleApplication1.IToy component) : base(component)
        {

        }



        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost()+70;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary()+ "I can dance SoloCapoeira ";
            }
            else
            {
                return String.Empty;
            }
        }
    }

    class GangnamStyleDance : Dances
    {

        public GangnamStyleDance(ConsoleApplication1.IToy component) : base(component)
        {

        }


        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost()+100;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary()+ "I can dance GangnamStyleDance ";
            }
            else
            {
                return String.Empty;
            }
        }
    }
    abstract class Stories : Decorator
    {

        public Stories(ConsoleApplication1.IToy component) : base(component)
        {

        }


        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost();
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary();
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class ScaryStories : Decorator
    {

        public ScaryStories(ConsoleApplication1.IToy component) : base(component)
        {

        }


        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost()+30;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary()+ "I tell scary stories";
            }
            else
            {
                return String.Empty;
            }
        }
    }
    class JokesStories : Decorator
    {

        public JokesStories(ConsoleApplication1.IToy component) : base(component)
        {

        }


        public override float Cost()
        {
            if (this._component != null)
            {
                return this._component.Cost() + 30;
            }
            else
            {
                return -1;
            }
        }

        public override string Summary()
        {
            if (this._component != null)
            {
                return this._component.Summary() + "I tell really funny jokes!";
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
