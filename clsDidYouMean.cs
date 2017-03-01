using System;
using System.Collections.Generic;
using System.Text;
 
namespace Did_You_Mean
{
    class clsDidYouMean
    {
        private int IndexOfMax(int[] input)
        {
            int index = 0;
            int max = 0;
            for(int x = 0; x <= input.Length-1 ; x++)
            {
                if(input[x] > max)
                {
                    index = x;
                    max = input[x];
                }
            }
            return index;
        }
 
 
 
        private int addPtsForSubstring(string input, string vectorString)
        {
            int pontos = 0;
            pontos++;
            if(input.Length == vectorString.Length)
            {
                pontos = pontos + 6;
            }
            else if(input.Length > vectorString.Length - 2 || input.Length < vectorString.Length + 2)
            {
                pontos = pontos + 3;
            }
                //if(DEBUGMODE)cout << inputResult << " - " << vectorString << " -ok\n";
            return pontos;
        }
 
 
        public string DidYouMean(string input, string[] banco)
        {
            int[] pontos = new int[banco.Length];
 
            for(int x = 0; x <= pontos.Length-1; x++)
            {
                pontos[x] = 0;
            }
 
            for (int x = 1; x <= input.Length; x++)
            {
                for (int i = 0; i < banco.Length; i++)
                {
                    string vectorString = banco[i];
                    string inputResult = input.Substring(0,x);
                    string inputResult2 = input.Substring(x,input.Length-x);
                    if(vectorString == input)
                    {
                        return vectorString;
                    }
                    else if(vectorString.Contains(inputResult))
                    {
                        pontos[i] = pontos[i] + addPtsForSubstring(input, vectorString);
                    }
                    else if(vectorString.Contains(inputResult2))
                    {
                        pontos[i] = pontos[i] + addPtsForSubstring(input, vectorString);
                    }
                }
            }
            return banco[IndexOfMax(pontos)];
        }
    }
}
