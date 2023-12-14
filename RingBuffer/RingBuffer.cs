namespace WeatherMonitoringSystem
{
  public class RingBuffer<T>
  {
    private T[] buffer;
    private int head;
    private int capacity;
    private int count;

    public RingBuffer(int capacity)
    {
      this.capacity = capacity;
      buffer = new T[capacity];
      head = 0;
      count = 0;
    }

    public void Add(T item)
    {
      buffer[head] = item;
      // this is the line that makes it a ring buffer
      head = (head + 1) % capacity;
      if (count < capacity) count++;
    }

    public T[] GetAll()
    {
      T[] items = new T[count];
      int cursor = head;
      for (int i = 0; i < count; i++)
      {
        cursor = (cursor - 1 + capacity) % capacity;
        items[i] = buffer[cursor];
      }
      return items;
    }
  }
}
