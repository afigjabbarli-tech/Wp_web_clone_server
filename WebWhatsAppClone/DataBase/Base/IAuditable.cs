namespace WebWhatsAppClone.DataBase.Base
{
    public interface IAuditable<TKey, TDate>
        where TKey : struct
        where TDate : struct
    {
        TKey? created_by { get; set; }
        TDate created_at { get; set; }
        TKey? updated_by { get; set; }
        TDate? updated_at { get; set; }
        bool is_active { get; set; }
        TDate? status_changed_at { get; set; }
        TKey? status_changed_by { get; set; }
        bool is_deleted { get; set; }
        TDate? deleted_at { get; set; }
        TKey? deleted_by { get; set; }
    }
}
