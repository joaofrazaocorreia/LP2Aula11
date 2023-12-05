namespace Indexers
{
    public struct MyVector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public MyVector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float this[string s]
        {
            get
            {
                switch(s.ToLower())
                {
                    case "x":
                        return X;

                    case "a":
                        return X;
                        
                    case "0":
                        return X;


                    case "y":
                        return Y;

                    case "b":
                        return Y;

                    case "1":
                        return Y;


                    default:
                        return 0;
                }
            }

            set
            {
                switch(s.ToLower())
                {
                    case "x":
                        X = value;
                        break;
                    
                    case "a":
                        X = value;
                        break;
                    
                    case "0":
                        X = value;
                        break;


                    case "y":
                        Y = value;
                        break;

                    case "b":
                        Y = value;
                        break;

                    case "1":
                        Y = value;
                        break;
                        

                    default:
                        break;
                }
            }
        }

        public float this[int i]
        {
            get
            {
                switch(i)
                {
                    case 0:
                        return X;

                    case 1:
                        return Y;
                        
                    default:
                        return 0;
                }
            }

            set
            {
                switch(i)
                {
                    case 0:
                        X = value;
                        break;

                    case 1:
                        Y = value;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}