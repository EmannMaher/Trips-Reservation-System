﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject
{
    class promotion
    {
        private static promotion instance;
            public static promotion Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new promotion();
                    }
                    return instance;
                }
            }

            public Boolean addPromotion(PromotionDTO promotion)
            {
                return PromotionDAO.Instance.addPromotion(promotion);
            }

            public void displayAll(DataGridView data)
            {
                data.DataSource = PromotionDAO.Instance.displayAll();
            }
            public int getID()
            {
                int ID = 1;
                List<int> promotionList = PromotionDAO.Instance.getID();
                foreach (int pro in promotionList)
                {
                    if (pro == ID)
                    {
                        ID++;
                    }
                    else
                    {
                        return ID;
                    }
                }
                return ID;
            }
            public Boolean updatePromotion(PromotionDTO promotion)
            {
                return PromotionDAO.Instance.updatePromotion(promotion);
            }
            public Boolean deletePromotion(int ID)
            {
                return PromotionDAO.Instance.deletePromotion(ID);
            }
        }
    }
}
