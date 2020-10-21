﻿using System;
using System.Collections.Generic;

namespace Task6NaiveFormulaProblems
{
    class Program
    {
        static float naive(float[] info)
        {
            float sum = 0.0f;
            foreach (float elem in info)
            {
                sum += elem;
            }
            return sum / info.Length;
        }
        static float knuth(float[] info)
        {
            float avg = 0.0f;
            for (int i = 0; i < info.Length; i++)
            {
                avg += ((float)info[i] - avg) / (i + 1);
            }
            return avg;
        }

        static void Main(string[] args)
        {
            float [] data = { 238936094815.75946f, 1227030410257.847f, 23304423139.1112f, 795996038702.3806f, 575982183987.3566f, 1084234746811.4481f, 253905299995.07584f, 502690529769.0554f, 9081347034.111193f, 119960586023.7086f, 487030191113.8349f, 37266915591.79047f, 773529110661.1873f, 211681631762.9622f, 518587111300.5747f, 1215253951956.5461f, 958655653121.4208f, 985173812095.2896f, 960228466508.327f, 921914416303.7388f, 786305633810.4584f, 719081148660.9359f, 211342387292.89188f, 1094250944714.8851f, 1124169315867.5564f, 958863064569.442f, 279133553867.14154f, 499780449641.3184f, 83882399212.17267f, 873754137833.0421f, 366274065551.9828f, 854161888051.1797f, 607559796077.0123f, 351119099655.20087f, 778750555891.821f, 1031682311922.9012f, 799721741375.3635f, 1188526985319.341f, 270076191420.42792f, 674431026531.3467f, 768367793003.4435f, 467528174461.81067f, 595420703896.0674f, 664515476107.8344f, 950011973499.9648f, 730634043087.1451f, 766591904082.1768f, 740568488369.3535f, 743458186631.9395f, 1126191152299.0159f, 596469653904.8788f, 982783384807.1123f, 1096243262629.5801f, 136605584084.30693f, 716368672858.2167f, 148582720367.33585f, 69280344940.27763f, 117445600851.1065f, 1169499641160.9324f, 188625463721.35886f, 1025731298360.1119f, 494670857072.5179f, 1193193843835.3481f, 648371190782.9369f, 306842091078.1211f, 1035458204767.9296f, 642595055079.4006f, 1184960249733.7756f, 1229666947397.1667f, 1088561795400.9932f, 148530469735.1107f, 389839662623.12067f, 258348933160.92633f, 670020722022.2006f, 257408328207.31253f, 133862372843.46024f, 637640183947.4391f, 1048234786311.4944f, 584957345662.5948f, 597123973978.9757f, 1000759077423.0066f, 179491056679.84268f, 720902974941.9419f, 9295472930.502655f, 99560364686.96729f, 516982853987.35364f, 991766035268.555f, 233211086099.28653f, 771833181558.0074f, 1134841157557.6484f, 304084442996.0003f, 316008199715.48627f, 68128446753.01875f, 703375468844.9071f, 14950440745.50265f, 909216797647.4626f, 1204874532482.0615f, 1162212146685.5732f};
            // the array data contains 98 integers which its avg = 634142998897.8148

            Console.WriteLine(naive(data)); // 6.3414285E+11
            Console.WriteLine(knuth(data)); // 6.3414305E+11



        }
    }
}