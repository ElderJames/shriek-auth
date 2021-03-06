﻿using System;
using System.Collections.Generic;
using System.Text;
using Shriek.Domains;

namespace Shriek.Auth.Domain
{
    public class AggregateRoot<TAggregateKey> : Domains.AggregateRoot<TAggregateKey> where TAggregateKey : IEquatable<TAggregateKey>
    {
        #region property

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; protected set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public string Creator { get; protected set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditDate { get; protected set; }

        /// <summary>
        /// 编辑者
        /// </summary>
        public string Editor { get; protected set; }

        #endregion property

        #region ctor

        /// <summary>
        ///
        /// </summary>
        /// <param name="aggregateId"></param>
        protected AggregateRoot(TAggregateKey aggregateId)
            : base(aggregateId)
        {
            this.CreateDate = this.EditDate = DateTime.Now;
            this.Editor = this.Creator = "sys";
        }

        #endregion ctor
    }
}