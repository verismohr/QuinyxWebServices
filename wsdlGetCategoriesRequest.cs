using System.ServiceModel;

namespace QuinyxWebServices;

[MessageContract(
    WrapperName = "wsdlGetCategories",
    WrapperNamespace = "uri:FlexForce",
    IsWrapped = true
)]
public class wsdlGetCategoriesRequest
{
    [MessageBodyMember(Namespace = "", Order = 0)]
    public string apiKey;

    [MessageBodyMember(Namespace = "", Order = 1)]
    public int categoryType;

    [MessageBodyMember(Namespace = "", Order = 2)]
    public string lastModified;

    public wsdlGetCategoriesRequest() { }

    public wsdlGetCategoriesRequest(string apiKey, int categoryType, string lastModified)
    {
        this.apiKey = apiKey;
        this.categoryType = categoryType;
        this.lastModified = lastModified;
    }
}
