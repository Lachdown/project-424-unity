﻿namespace Perrinn424
{
    public static class TimeReferenceHelper
    {
        public static TimeReference CreatePorsche()
        {
            var porsche = new TimeReference(new[]
           { 
                0, 41, 94, 147, 186, 217, 244, 279, 326, 383, 449, 519, 587, 655, 726, 799, 876, 939, 991, 1034, 1080, 
                1135, 1195, 1245, 1291, 1332, 1379, 1433, 1476, 1516, 1556, 1607, 1666, 1737, 1814, 1894, 1978, 2063, 
                2148, 2228, 2306, 2381, 2459, 2539, 2620, 2704, 2790, 2879, 2971, 3064, 3159, 3253, 3344, 3431, 3516, 
                3597, 3679, 3762, 3820, 3864, 3904, 3945, 3996, 4059, 4130, 4209, 4292, 4375, 4462, 4549, 4639, 4730, 
                4821, 4904, 4974, 5044, 5101, 5156, 5198, 5228, 5258, 5292, 5327, 5373, 5429, 5498, 5573, 5651, 5732, 
                5817, 5899, 5970, 6040, 6113, 6169, 6213, 6258, 6310, 6369, 6430, 6472, 6508, 6546, 6596, 6654, 6718, 
                6782, 6849, 6919, 6981, 7042, 7106, 7174, 7245, 7310, 7360, 7398, 7424, 7448, 7481, 7527, 7584, 7646, 
                7714, 7786, 7854, 7902, 7943, 7992, 8049, 8099, 8142, 8187, 8242, 8306, 8378, 8458, 8539, 8624, 8710, 
                8794, 8858, 8906, 8946, 8988, 9041, 9103, 9174, 9249, 9330, 9411, 9494, 9578, 9662, 9747, 9833, 9920, 
                10009, 10099, 10194, 10291, 10388, 10484, 10577, 10670, 10760, 10835, 10907, 10980, 11056, 11134, 11212, 
                11289, 11366, 11443, 11510, 11559, 11594, 11624, 11659, 11704, 11756, 11815, 11877, 11936, 11978, 12007, 
                12033, 12059, 12085, 12114, 12150, 12199, 12259, 12324, 12395, 12468, 12542, 12617, 12695, 12759, 12819,
                12877, 12935, 12989, 13038, 13085, 13141, 13202, 13269, 13340, 13409, 13466, 13523, 13580, 13638, 13703, 
                13756, 13802, 13852, 13908, 13964, 14013, 14063, 14118, 14169, 14215, 14263, 14319, 14378, 14421, 14463,
                14508, 14563, 14621, 14668, 14707, 14747, 14799, 14858, 14923, 14992, 15065, 15141, 15209, 15272, 15334, 
                15396, 15460, 15525, 15595, 15668, 15743, 15820, 15901, 15983, 16067, 16154, 16241, 16328, 16416, 16485, 
                16553, 16619, 16669, 16715, 16769, 16828, 16881, 16918, 16950, 16985, 17030, 17086, 17147, 17214, 17272, 
                17329, 17389, 17454, 17517, 17585, 17658, 17738, 17823, 17913, 18008, 18105, 18205, 18307, 18410, 18511, 
                18613, 18714, 18817, 18919, 19021, 19123, 19224, 19325, 19426, 19527, 19625, 19724, 19821, 19918, 20015, 
                20108, 20197, 20282, 20365, 20430, 20474, 20518, 20549, 20584, 20622, 20663, 20690, 20720, 20737 
            });

            return porsche;
        }

        public static TimeReference CreateVolkswagen()
        {
            var volkswagen = new TimeReference(new[]
            { 
                0, 39, 87, 139, 185, 219, 248, 278, 316, 363, 416, 475, 539, 603, 665, 730, 799, 871, 933, 984, 1028, 1067, 
                1108, 1157, 1211, 1259, 1301, 1337, 1373, 1417, 1468, 1512, 1549, 1582, 1625, 1674, 1729, 1791, 1856, 1926, 
                1999, 2072, 2146, 2220, 2293, 2361, 2425, 2495, 2565, 2638, 2713, 2786, 2860, 2935, 3010, 3085, 3161, 3236, 
                3310, 3383, 3457, 3530, 3600, 3669, 3742, 3809, 3859, 3899, 3933, 3970, 4013, 4064, 4093, 4157, 4226, 4298,
                4373, 4449, 4524, 4600, 4677, 4751, 4822, 4891, 4955, 5015, 5069, 5113, 5158, 5196, 5233, 5258, 5287, 5316, 
                5350, 5395, 5448, 5507, 5571, 5640, 5710, 5785, 5859, 5930, 5992, 6053, 6119, 6173, 6213, 6249, 6291, 6340, 
                6395, 6446, 6484, 6517, 6551, 6596, 6644, 6703, 6767, 6829, 6896, 6964, 7022, 7077, 7134, 7196, 7265, 7323, 
                7370, 7405, 7432, 7455, 7485, 7523, 7570, 7623, 7683, 7747, 7816, 7875, 7919, 7958, 7998, 8045, 8094, 8130, 
                8166, 8211, 8263, 8322, 8387, 8455, 8526, 8599, 8672, 8746, 8814, 8866, 8908, 8943, 9043, 9030, 9079, 9133, 
                9194, 9258, 9325, 9393, 9463, 9533, 9603, 9673, 9745, 9817, 9888, 9958, 10028, 10098, 10168, 10238, 10307, 
                10375, 10444, 10513, 10581, 10650, 10719, 10787, 10850, 10915, 10980, 11046, 11111, 11178, 11246, 11313, 
                11381, 11448, 11508, 11550, 11582, 11609, 11640, 11679, 11724, 11777, 11833, 11894, 11943, 11977, 12004, 
                12027, 12052, 12075, 12101, 12135, 12178, 12230, 12287, 12349, 12415, 12482, 12547, 12614, 12681, 12743, 
                12798, 12850, 12899, 12951, 12998, 13042, 13084, 13135, 13194, 13258, 13325, 13388, 13446, 13499, 13555, 
                13607, 13662, 13721, 13768, 13813, 13864, 13923, 13974, 14022, 14071, 14127, 14176, 14218, 14265, 14320, 
                14375, 14415, 14451, 14489, 14537, 14592, 14644, 14684, 14720, 14761, 14788, 14862, 14925, 14991, 15060, 
                15130, 15199, 15258, 15309, 15364, 15418, 15475, 15540, 15606, 15672, 15743, 15814, 15881, 15947, 16016, 
                16086, 16153, 16224, 16295, 16366, 16434, 16497, 16556, 16614, 16659, 16704, 16751, 16805, 16863, 16905, 
                16937, 16969, 17010, 17058, 17114, 17173, 17235, 17290, 17344, 17401, 17463, 17528, 17592, 17654, 17718, 
                17783, 17849, 17914, 17983, 18052, 18121, 18192, 18262, 18332, 18400, 18470, 18540, 18609, 18679, 18748, 
                18818, 18886, 18956, 19024, 19092, 19159, 19228, 19296, 19363, 19432, 19500, 19567, 19635, 19704, 19773, 
                19841, 19911, 19981, 20050, 20120, 20187, 20254, 20319, 20384, 20443, 20491, 20525, 20554, 20586, 20624, 
                20666, 20699, 20728, 20737 
            });


            return volkswagen;
        }
    }
}
