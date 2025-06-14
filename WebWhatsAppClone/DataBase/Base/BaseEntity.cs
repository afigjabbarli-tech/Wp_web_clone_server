namespace WebWhatsAppClone.DataBase.Base
{
    public abstract class BaseEntity<TKey>
        where TKey : struct
    {
        public TKey id { get; set; } = default;
    }
}
