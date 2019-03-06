using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基本结构
            //Abstraction ab = new RefinedAbstraction();

            //ab.SetImplementor(new ConcreteImplentorA());
            //ab.Operation();

            //ab.SetImplementor(new ConcreteImplentorB());
            //ab.Operation(); 
            #endregion

            HandsetBrand ab;
            ab = new HandsetBrandN();

            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();


            ab = new HandsetBrandM();

            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            Console.ReadKey();
        }
    }
}
