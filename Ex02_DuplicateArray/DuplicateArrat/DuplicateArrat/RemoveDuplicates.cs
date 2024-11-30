﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateArray
{
    internal class RemoveDuplicates
    {
        public int RemoveDuplicate(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }

            return j + 1;
        }
    }
}
