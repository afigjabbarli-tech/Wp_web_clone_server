namespace WebWhatsAppClone.DataBase.Base
{
    public abstract class AuditableEntity<TKey, TDate> : BaseEntity<TKey>, IAuditable<TKey, TDate>
        where TKey : struct
        where TDate : struct
    {
        public TKey? created_by { get; set; }
        public TDate created_at { get; set; }
        public bool is_updated { get; set; } = false;
        public TKey? updated_by { get; set; }
        public TDate? updated_at { get; set; }
        public bool is_active { get; set; } = true;
        public TDate? status_changed_at { get; set; }
        public TKey? status_changed_by { get; set; }
        public bool is_deleted { get; set; } = false;
        public TDate? deleted_at { get; set; }
        public TKey? deleted_by { get; set; }
    }
}
