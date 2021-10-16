namespace DatingService.Domain
{
    public abstract class FileEntity<TKey> : BaseEntity<TKey>
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
