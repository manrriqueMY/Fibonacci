using Fibonacci.Models;

namespace Fibonacci.Service
{
    public class FibonacciService
    {
        public Response FindPosition(int position)
        {
            if (position < 1) return new Response()
            {
                Status=400,
                Message= "`position` must be greater than `0`",
            };

            int a = 0, b = 1, index = 0;

            while (index < position)
            {
                int temp = a;
                a = b;
                b = temp + b;
                index++;
            }
            return new Response()
            {
                Data = a,
                Status = 200,
            };            
        }
    }
}
