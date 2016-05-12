using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "t133l16g<ggggggggggg>f<ggggggggggg>d+<ggggggggggg>d<gggggggg1>>d<dddddddddddb+ddddddddddda+dddddddddddadddddddd2>dc<a+agf+edc<a+aggggggggg>>gfd+dc<a+agfd+dccccccccc>a+agfd+dc<a+agfd+d+d+d+d+d+d+d+d+>>dc<a+agf+edc<a+aggggggggg>>dc<a+agf+d+dc<a+agggggggg>d<ggg>d<ggg>d<gggdaa+>cdef+ga4<aa+>cdef+ga4<a+>cdd+f+gaa+4def+gaa+>cd4<def+gaa+>cd4<<aa+>cdef+ga4<a+>cdd+f+gaa+4def+gaa+>cd4<a+gd<a+>a+gd<a+>a+gd<a+>d<a+gd>d<a+gd>d<a+gdgd<a+g>gd<a+g>gd<a+g>gbgbgbgbgbgbgb+gb+gb+gb+gb+gb+g>c+<g>c+<g>c+<g>c+<g>c+<g>c+<a>d<a>d<a>d<a>d<a>d<a>d<a>c+<a>c+<a>c+<a>c+<a>c+<a>c+d<defgab>c+d<ab>c+defgadefgaa+>c+d4<aa>c+c+eeaa<a<d>a>g<a<d>a>f<a<d>a>e<a<d>a>f<a<d>a>g<a<d>a>a<a<d>a>g<a<d>a>f<a<d>a>e4<ddffaa>dd<d<d>db+d<d>da+d<d>dad<d>da+d<d>d>c+<d<d>d>d<d<d>db+d<d>da+d<d>da4>aaggffd+d+ddcc<a+a+aaggffeeddcc<a+a+aag+l8ag+ag+afgd+fdd+c+dc+dc+dc+dc+dcdcddd>dfaa+<dd>dga+a+<ee>d+ga+a<ff>cfaa<dd>dfag<d+d+a+>d+gg<cc>cd+gg<ddb>dgf<ddb>dfl16d+<d+fgg+b>cdd+4<d+fgg+b>cdd+4<d+fgg+b>cdd+4<d+>c<a+>c<d+>c<a+>c<d+>c<a+>c<fb+a+b+fb+a+b+fb+a+b+gb+bb+gb+bb+gb+b>cc<ccccccccccca+cccccccccccg+cccccccccccgcccccccc4>d+cd+cd+cd+cd+cd+cdc-dc-dc-dc-dc-dc-d+cd+cd+cd+cd+cd+cd<a+>d<a+>d<a+>d<a+>d<a+>d<a+>d+<a+>d+<a+>d+<a+>d+<a+>d+<a+>d+<a+>d+ggg+g+a+a+>ccddd+d+<a+gd+>d+<a+gd+>d+<a+gd+gg+g+a+a+>ccddd+d+ffc<af>fc<af>fc<afga+a+>ccddd+d+ffggd<bg>gd<bg>gd<bg>d+<<cccccccccccg+cccg+cccg+ccc<bbbbbbbbbbbb>g<a+a+a+>g<a+a+a+>g<a+a+a+aaaaaaaaaaaa>f<g+g+g+>f<g+g+g+>f<g+g+g+g>ggggggggggg>d+<ggg>d+<ggg>d+<gggf+f+f+f+f+f+f+f+f+f+f+f+>d<fff>d<fff>d<fffeeeeeeeeeeeeb+d+d+d+b+d+d+d+b+d+d+d+ddddf+dddaddda+dddb+ddd>d<ddd>d+<ddd>f+<ddd>g<ddd>a<ddd>a+<ddd>b+<ddd>>d<dc<a+agf+edc<a+aggggggggggggg>>gfd+dc<a+agfd+dccccccccccccc>a+agfd+dc<a+agfd+d+d+d+d+d+d+d+d+>>dc<a+agf+edc<a+agggggggggggg>g<g<g>g>f<g<g>g>d+<g<g>>d+<ggaa+>cdef+gaa+agfd+dc<a+agf+edc<a+ga+ga+ga+ga+ga+g>d+df+egf+aga+ab+a+>dcd+dfegf+aga+a<d+df+egf+aga+ab+a+>dcd+dfegf+aga+a<ddddddddddddgd<a+g>gd<a+g>gd<a+g>ggggggggggggf+f+f+f+f+f+f+f+f+f+f+f+gggga+a+a+a+>ddddgggga+a+a+a+ggggdddd<a+a+a+a+gggg<g1";
            using (var fs = File.OpenWrite(@"HexOutput.txt"))
            using (var writer = new StreamWriter(fs))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    writer.Write("0x{0:X}", (int)str[i]);
                    if (i < str.Length - 1)
                    {
                        writer.Write(",");
                        writer.Write(i % 16 == 15 ? Environment.NewLine : " ");
                    }
                }
            }
        }
    }
}
