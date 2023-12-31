namespace JuegoOlimpico.Transversal.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; } = true;
        public bool IsWarning { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
