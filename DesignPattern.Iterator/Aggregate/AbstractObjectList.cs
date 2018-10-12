﻿using System;
using System.Collections.Generic;
using DesignPattern.Iterator.Iterator;

namespace DesignPattern.Iterator.Aggregate
{
    /// <summary>
    /// 抽象聚合类：AbstractObjectList
    /// </summary>
    public abstract class AbstractObjectList
    {
        protected IList<object> objectList = new List<object>();

        public AbstractObjectList (IList<object> objectList)
        {
            this.objectList = objectList;
        }

        public void AddObject(object obj)
        {
            this.objectList.Add(obj);
        }

        public void RemoveObject(object obj)
        {
            this.objectList.Remove(obj);
        }

        public IList<Object> GetObjectList()
        {
            return this.objectList;
        }

        // 声明创建迭代器对象的抽象工厂方法
        public abstract AbstractIterator CreateIterator();
    }
}
