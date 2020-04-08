using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using StatefulModel;

namespace TransparentWindow.Composite.Collections
{
    public class SyncCollection<T> : IList<T>, ICollection<T>
    {
        public SynchronizationContextCollection<T> Items { get; set; }

        public T this[int index] { get => this.Items[index]; set => this.Items[index] = value; }

        public int Count => this.Items.Count;

        public bool IsReadOnly => this.Items.IsReadOnly;

        public void Add(T item)
        {
            this.Items.Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items) {
                this.Items.Add(item);
            }
        }

        public void Clear()
        {
            this.Items.Clear();
        }

        public bool Contains(T item)
        {
            return this.Items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return this.Items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this.Items.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return this.Items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        public SyncCollection()
        {
            this.Items = new SynchronizationContextCollection<T>(System.Threading.SynchronizationContext.Current);
        }

        public SyncCollection(ISynchronizableNotifyChangedCollection<T> collection)
        {
            this.Items = collection.ToSyncedSynchronizationContextCollection(System.Threading.SynchronizationContext.Current);
        }
    }
}
