// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchImV2TagsByTagIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改标签 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 修改标签 响应体
/// <para>接口ID：7315032956271296516</para>
/// <para>文档地址：https://open.feishu.cn/document/tenant-tag/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ftag%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchImV2TagsByTagIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tag_info": {
            "id": "716168xxxxx",
            "tag_type": "tenant",
            "name": "标签1",
            "i18n_names": [
                {
                    "locale": "zh_cn",
                    "name": "标签2"
                }
            ],
            "create_time": "1700793403850",
            "update_time": "1700793403850"
        },
        "patch_tag_fail_reason": {
            "duplicate_id": "716168xxxxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PatchImV2TagsByTagIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}