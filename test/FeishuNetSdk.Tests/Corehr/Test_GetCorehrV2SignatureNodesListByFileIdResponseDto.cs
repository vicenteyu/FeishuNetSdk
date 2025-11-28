// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_GetCorehrV2SignatureNodesListByFileIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取文件签署节点信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取文件签署节点信息 响应体
/// <para>接口ID：7398535900936863747</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/list_by_file_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_node%2flist_by_file_id</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2SignatureNodesListByFileIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "signature_nodes": [
            {
                "user_infos": [
                    {
                        "id": "7300476612163913260"
                    }
                ],
                "state": "Initiated",
                "finish_time": "2021-12-31 12:21:10",
                "updated_time": "2021-12-31 12:21:10",
                "is_ongoing": false,
                "role_label": {
                    "zh": "发起",
                    "en": "Initiate"
                },
                "sign_role": "Initiator"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2SignatureNodesListByFileIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}