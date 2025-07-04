// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1PermissionsByTokenMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取协作者列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取云文档协作者 响应体
/// <para>接口ID：7121656165336367106</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1PermissionsByTokenMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "items": [
            {
                "member_type": "openid",
                "member_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "perm": "view",
                "perm_type": "container",
                "type": "user",
                "name": "zhangsan",
                "avatar": "https://s3-imfile.feishucdn.com/static-resource/v1/v3_0061_b576862d-92e0-4abc-bbb5-6f78f927a61g~?image_size=72x72&cut_type=default-face&quality=&format=jpeg&sticker_format=.webp",
                "external_label": true
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1PermissionsByTokenMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}