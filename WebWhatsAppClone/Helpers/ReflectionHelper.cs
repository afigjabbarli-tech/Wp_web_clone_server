namespace WebWhatsAppClone.Helpers
{
    public class ReflectionHelper
    {
        public object? GetPropertyValueByPropertyName(object obj, string property_name)
        {
            var properties = obj.GetType().GetProperties();
            var property = properties.FirstOrDefault((property) => property.Name == property_name);
            if(property == null)
            {
                return null;
            }
            var value = property.GetValue(obj);
            if(value == null)
            {
                return null;
            }
            return value;
        }
    }
}
