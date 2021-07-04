using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class TokenManager
    {
        private Token _tokens;

        public void Add(Token token)
        {
            _tokens = token | _tokens;
        }
        public void Remove(Token token)
        {
            if(Has(token))
            {
                _tokens = token ^ _tokens;
            }
            else
            {
                Console.WriteLine("没有这个权限");
            }
        }
        public bool Has(Token token)
        {
           return _tokens == (token & _tokens);
        }
    }
}
