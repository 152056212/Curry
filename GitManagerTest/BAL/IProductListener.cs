using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public interface IProductListener
    {
        /// <summary>
        /// 调拨监听
        /// </summary>
        void isAdjustChecked(int adjustNum);
        /// <summary>
        /// 审核入库监听
        /// </summary>
        void isInCheck(int inNum);
        /// <summary>
        /// 审核出库监听
        /// </summary>
        void isOutCheck( int outNum );
        /// <summary>
        /// 采购监听
        /// </summary>
        void storehouseInput( int buyNum );
        /// <summary>
        /// 付款监听
        /// </summary>
        void isPay( int payNum );
        /// <summary>
        /// 生产监听
        /// </summary>
        void isNewProduct( int productNum );
        
    }
}
