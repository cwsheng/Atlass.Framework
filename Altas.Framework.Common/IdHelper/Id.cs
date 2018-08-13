﻿using System;

namespace Altas.Framework.Common.IdHelper {
    /// <summary>
    /// 标识生成器
    /// </summary>
    public static class Id {
        /// <summary>
        /// 标识
        /// </summary>
        private static string _id;

        /// <summary>
        /// 设置标识
        /// </summary>
        /// <param name="id">Id</param>
        public static void SetId( string id ) {
            _id = id;
        }

        /// <summary>
        /// 重置标识
        /// </summary>
        public static void Reset() {
            _id = null;
        }

        /// <summary>
        /// 创建标识
        /// </summary>
        public static string ObjectId() {
            return string.IsNullOrWhiteSpace( _id ) ? IdHelper.ObjectId.GenerateNewStringId() : _id;
        }

    }
}
