using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;

namespace MoqCallback
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result;

            var mockDoIt = new Mock<IDosomething>();
            mockDoIt.Setup(x => x.DoIt(It.IsAny<int>())).Callback<int>(r => result = r);

            var handler = new Handler(mockDoIt.Object);
            handler.Handle().Wait();

        }
    }
}
