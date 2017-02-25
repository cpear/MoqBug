using System.Threading.Tasks;

namespace MoqCallback
{
    public class Handler
    {
        private readonly IDosomething _iDo;

        public Handler(IDosomething iDo)
        {
            _iDo = iDo;
        }

        public async Task Handle()
        {
            var testValueToReturn = 700;

            await _iDo.DoIt(testValueToReturn);
        }
    }

    public interface IDosomething
    {
        Task DoIt(int testValue);
    }
}
