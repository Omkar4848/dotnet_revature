class DataStore<T>
{
  private T value;

  public void Set(T data)
  {
    value = data;
  }

  public T Get()
  {
    return value;
  }
}
