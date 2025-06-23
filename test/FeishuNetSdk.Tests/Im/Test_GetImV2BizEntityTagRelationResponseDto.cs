namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 查询实体与标签的绑定关系 响应体
/// <para>接口ID：7350335258430816257</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fbiz_entity_tag_relation%2fget</para>
/// </summary>
[TestClass]
public class Test_GetImV2BizEntityTagRelationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tag_info_with_bind_versions": [
            {
                "tag_info": {
                    "id": "716168xxxxx",
                    "tag_type": "tenant",
                    "name": "tagName1",
                    "i18n_names": [
                        {
                            "locale": "zh-CN",
                            "name": "tagName1"
                        }
                    ],
                    "create_time": "1700793403850",
                    "update_time": "1700793403850"
                },
                "bind_version": "1710401562336"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV2BizEntityTagRelationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}