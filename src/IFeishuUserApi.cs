using FeishuNetSdk.Attributes;
using FeishuNetSdk.Parameters;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace FeishuNetSdk;
/// <summary>
/// 适用于自建应用用户凭证（UserAccessToken）的接口
/// </summary>
[EnableLoggingFilter]
[IgnoreStatusExceptionFilter]
[HttpHost("https://open.feishu.cn/"), JsonReturn]
public interface IFeishuUserApi : IHttpApi
{
    /// <summary>
    /// <para>【云文档】导入表格</para>
    /// <para>接口ID：6907568031544229890</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATO2YjLwkjN24CM5YjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>&gt; 为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至[新版本](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)</para>
    /// <para>该接口用于将本地表格导入到云空间上。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/import")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2ImportResponseDto>> PostSheetsV2ImportAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostSheetsV2ImportBodyDto dto);

    /// <summary>
    /// <para>【云文档】写入图片</para>
    /// <para>接口ID：6907568073252585474</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDNxYjL1QTM24SN0EjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>向电子表格某个工作表的单个指定单元格写入图片，支持传入图片的二进制流，支持多种图片格式。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values_image")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto dto);

    /// <summary>
    /// <para>【云文档】查询导入结果</para>
    /// <para>接口ID：6907568073252683778</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uETO2YjLxkjN24SM5YjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于查询文件导入结果。查询30分钟无结果为导入失败。</para>
    /// </summary>
    /// <param name="ticket">
    /// <para>必填：是</para>
    /// <para>导入时获取的凭证</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/import/result")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2ImportResultResponseDto>> GetSheetsV2ImportResultAsync(
        UserAccessToken access_token,
        [PathQuery] string ticket);

    /// <summary>
    /// <para>【云文档】设置单元格样式 </para>
    /// <para>接口ID：6907569523176783873</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukjMzUjL5IzM14SOyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>设置单元格中数据的样式。支持设置字体、背景、边框等样式。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/style")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleResponseDto>> PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleBodyDto dto);

    /// <summary>
    /// <para>【云文档】复制文档</para>
    /// <para>接口ID：6907569523177127937</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYTNzUjL2UzM14iN1MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/copy)</para>
    /// <para>将文件复制到用户云空间的其他文件夹中。不支持复制文件夹。</para>
    /// <para>如果目标文件夹是我的空间，则复制的文件会在「我的空间」的「归我所有」列表里。</para>
    /// <para>该接口不支持并发创建，且调用频率上限为 5QPS 且 10000次/天</para>
    /// </summary>
    /// <param name="fileToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>被复制文件的 token, 获取方式见 [概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/files/guide/introduction)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("迁移至新版本：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/copy")]
    [HttpPost("/open-apis/drive/explorer/v2/file/copy/files/{fileToken}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDriveExplorerV2FileCopyFilesByFileTokenResponseDto>> PostDriveExplorerV2FileCopyFilesByFileTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string fileToken,
        [JsonContent] Ccm.Spec.PostDriveExplorerV2FileCopyFilesByFileTokenBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取协作者列表</para>
    /// <para>接口ID：6907569523177324545</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATN3UjLwUzN14CM1cTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件的 token 查询协作者，目前包括人("user")和群("chat") 。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("历史版本")]
    [HttpPost("/open-apis/drive/permission/member/list")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDrivePermissionMemberListResponseDto>> PostDrivePermissionMemberListAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostDrivePermissionMemberListBodyDto dto);

    /// <summary>
    /// <para>【云文档】搜索云文档</para>
    /// <para>接口ID：6907569523177439233</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ugDM4UjL4ADO14COwgTN</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于根据搜索关键词（search_key）对当前用户可见的云文档进行搜索。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/suite/docs-api/search/object")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSuiteDocsApiSearchObjectResponseDto>> PostSuiteDocsApiSearchObjectAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostSuiteDocsApiSearchObjectBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取云文档权限设置V2</para>
    /// <para>接口ID：6907569524099940353</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uITM3YjLyEzN24iMxcjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 获取云文档的权限设置。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/permission/v2/public/")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDrivePermissionV2PublicResponseDto>> PostDrivePermissionV2PublicAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostDrivePermissionV2PublicBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取文件夹元数据</para>
    /// <para>接口ID：6907569524099989505</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uAjNzUjLwYzM14CM2MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件夹 token 获取该文件夹的元数据，包括文件夹的 ID、名称、创建者 ID 等。</para>
    /// </summary>
    /// <param name="folderToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件夹 token。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/explorer/v2/folder/{folderToken}/meta")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDriveExplorerV2FolderByFolderTokenMetaResponseDto>> GetDriveExplorerV2FolderByFolderTokenMetaAsync(
        UserAccessToken access_token,
        [PathQuery] string folderToken);

    /// <summary>
    /// <para>【云文档】拆分单元格</para>
    /// <para>接口ID：6907569524100055041</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATNzUjLwUzM14CM1MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>拆分电子表格工作表中的单元格。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/unmerge_cells")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsBodyDto dto);

    /// <summary>
    /// <para>【通讯录】搜索用户</para>
    /// <para>接口ID：6907569524100349953</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uMTM4UjLzEDO14yMxgTN</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>以用户身份搜索其他用户的信息，无法搜索到外部企业或已离职的用户。</para>
    /// <para>调用该接口需要申请 `搜索用户` 权限。</para>
    /// </summary>
    /// <param name="query">
    /// <para>必填：是</para>
    /// <para>要执行搜索的字符串，一般为用户名。</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小，最小为 1，最大为 200，默认为 20。</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标识，获取首页不需要填写，获取下一页时传入上一页返回的分页标识值。</para>
    /// <para>请注意此字段的值并没有特殊含义，请使用每次请求所返回的标识值。</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/search/v1/user?query=zhangsan&amp;page_size=20")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.Spec.GetSearchV1UserResponseDto>> GetSearchV1UserAsync(
        UserAccessToken access_token,
        [PathQuery] string query,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【云文档】删除行列</para>
    /// <para>接口ID：6907569524100382721</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ucjMzUjL3IzM14yNyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除电子表格中的指定行或列。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dimension_range")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto>> DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取旧版文档元信息</para>
    /// <para>接口ID：6907569524100448257</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uczN3UjL3czN14yN3cTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口只支持查询旧版文档元信息。要查询新版文档（`docx` 类型）元信息，使用[获取文档元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/meta/batch_query)接口。</para>
    /// </summary>
    /// <param name="docToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>doc 的 token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/doc/v2/meta/{docToken}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDocV2MetaByDocTokenResponseDto>> GetDocV2MetaByDocTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string docToken);

    /// <summary>
    /// <para>【云文档】追加数据</para>
    /// <para>接口ID：6907569524100857857</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uMjMzUjLzIzM14yMyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在电子表格工作表的指定范围中，在空白位置中追加数据。例如，若指定范围参数 `range` 为 `6e5ed3!A1:B2`，该接口将会依次寻找 A1、A2、A3...单元格，在找到的第一个空白位置中写入数据。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="insertDataOption">
    /// <para>必填：否</para>
    /// <para>指定追加数据的方式，默认值为 OVERWRITE，即若空行数量小于追加数据的行数，则会覆盖已有数据。可选值：</para>
    /// <para>- OVERWRITE：若空行的数量小于追加数据的行数，则会覆盖已有数据</para>
    /// <para>- INSERT_ROWS：插入足够数量的行后再进行数据追加</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values_append")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto dto,
        [PathQuery] string? insertDataOption = null);

    /// <summary>
    /// <para>【云文档】获取文件夹下的文档清单</para>
    /// <para>接口ID：6907569524100890625</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uEjNzUjLxYzM14SM2MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>获取用户云空间中指定文件夹下的文件清单。清单类型包括文件、各种在线文档（文档、电子表格、多维表格、思维笔记）、文件夹和快捷方式。该接口不支持分页，并且不会递归的获取子文件夹的清单。</para>
    /// </summary>
    /// <param name="folderToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件夹的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// </param>
    /// <param name="types">
    /// <para>必填：否</para>
    /// <para>需要查询的文件类型，默认返回所有 children；types 可多选，可选类型有 doc、sheet、file、bitable、docx、folder、mindnote 。如 url?types=folder&amp;types=sheet</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("迁移至新版本：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list")]
    [HttpGet("/open-apis/drive/explorer/v2/folder/{folderToken}/children")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDriveExplorerV2FolderByFolderTokenChildrenResponseDto>> GetDriveExplorerV2FolderByFolderTokenChildrenAsync(
        UserAccessToken access_token,
        [PathQuery] string folderToken,
        [PathQuery] string[]? types = null);

    /// <summary>
    /// <para>【会议室】查询会议室忙闲</para>
    /// <para>接口ID：6907569524100956161</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uIDOyUjLygjM14iM4ITN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口获取指定会议室的忙碌、空闲日程信息。</para>
    /// <para>查询结果中：</para>
    /// <para>- 非重复日程只有唯一的实例信息。</para>
    /// <para>- 重复日程可能存在多个实例信息，根据日程重复规则和时间范围进行扩展。建议查询的时间区间为 30 天内。</para>
    /// </summary>
    /// <param name="room_ids">
    /// <para>必填：是</para>
    /// <para>会议室 ID。你可以通过[查询会议室列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/list)或[搜索会议室](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/search)接口获取指定会议室 ID。</para>
    /// <para>1. room_ids个数不要超过20。</para>
    /// <para>2. GET 请求中传入多个会议室 ID 的格式示例为 `room_ids=omm_83d09ad4f6896e02029a6a075f71xxxx&amp;room_ids=omm_eada1d61a550955240c28757e7dexxxx`。</para>
    /// </param>
    /// <param name="time_min">
    /// <para>必填：是</para>
    /// <para>查询的起始时间，需要遵循 [RFC3339](https://tools.ietf.org/html/rfc3339) 格式，示例：2019-09-04T08:45:00+08:00。</para>
    /// <para>**注意**：传入该参数时需要进行 URL 编码。</para>
    /// </param>
    /// <param name="time_max">
    /// <para>必填：是</para>
    /// <para>查询的结束时间，需要遵循 [RFC3339](https://tools.ietf.org/html/rfc3339) 格式，示例：2019-09-04T09:45:00+08:00。</para>
    /// <para>**注意**：传入该参数时需要进行 URL 编码。</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/meeting_room/freebusy/batch_get")]
    System.Threading.Tasks.Task<FeishuResponse<MeetingRoom.Spec.GetMeetingRoomFreebusyBatchGetResponseDto>> GetMeetingRoomFreebusyBatchGetAsync(
        UserAccessToken access_token,
        [PathQuery] string[] room_ids,
        [PathQuery] string time_min,
        [PathQuery] string time_max);

    /// <summary>
    /// <para>【云文档】判断协作者是否有某权限</para>
    /// <para>接口ID：6907569524101087233</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYzN3UjL2czN14iN3cTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 判断当前登录用户是否具有某权限。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/permission/member/permitted")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDrivePermissionMemberPermittedResponseDto>> PostDrivePermissionMemberPermittedAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostDrivePermissionMemberPermittedBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新行列</para>
    /// <para>接口ID：6907569742383562754</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYjMzUjL2IzM14iNyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新设置电子表格中行列的属性，包括是否隐藏行列和设置行高列宽。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dimension_range")]
    System.Threading.Tasks.Task<FeishuResponse> PutSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto dto);

    /// <summary>
    /// <para>【云文档】删除Doc</para>
    /// <para>接口ID：6907569742383661058</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATM2UjLwEjN14CMxYTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete)</para>
    /// <para>该接口用于根据 docToken 删除对应的 Docs 文档。</para>
    /// <para>文档只能被文档所有者删除，文档被删除后将会放到回收站里</para>
    /// <para>该接口不支持并发调用，且调用频率上限为5QPS</para>
    /// </summary>
    /// <param name="docToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>doc 的 token，获取方式见 [概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/files/guide/introduction)</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("迁移至新版本：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete")]
    [HttpDelete("/open-apis/drive/explorer/v2/file/docs/{docToken}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.DeleteDriveExplorerV2FileDocsByDocTokenResponseDto>> DeleteDriveExplorerV2FileDocsByDocTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string docToken);

    /// <summary>
    /// <para>【云文档】批量设置单元格样式 </para>
    /// <para>接口ID：6907569742383923202</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uAzMzUjLwMzM14CMzMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>批量设置单元格中数据的样式。支持设置字体、背景、边框等样式。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/styles_batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateResponseDto>> PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateBodyDto dto);

    /// <summary>
    /// <para>【云文档】增加保护范围</para>
    /// <para>接口ID：6907569742383988738</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ugDNzUjL4QzM14CO0MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 spreadsheetToken 和维度信息增加多个保护范围；单次操作不超过5000行或列。</para>
    /// <para>仅支持设置保护行或保护列，暂不支持设置保护单元格</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>请求的用户id类型，可选open_id,union_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/protected_dimension")]
    System.Threading.Tasks.Task<FeishuResponse> PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】更新表格属性</para>
    /// <para>接口ID：6907569742384201730</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ucTMzUjL3EzM14yNxMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 spreadsheetToken 更新表格属性，如更新表格标题。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/properties")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesResponseDto>> PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenPropertiesBodyDto dto);

    /// <summary>
    /// <para>【云文档】向多个范围写入数据</para>
    /// <para>接口ID：6907569742384381954</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uEjMzUjLxIzM14SMyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>向电子表格某个工作表的多个指定范围中写入数据。若指定范围已内有数据，将被新写入的数据覆盖。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values_batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateBodyDto dto);

    /// <summary>
    /// <para>【云文档】插入数据</para>
    /// <para>接口ID：6907569742384398338</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uIjMzUjLyIzM14iMyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在电子表格工作表的指定范围的起始位置上方增加若干行，并在该范围中填充数据。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values_prepend")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependBodyDto dto);

    /// <summary>
    /// <para>【云文档】读取单个范围</para>
    /// <para>接口ID：6907569742384529410</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ugTMzUjL4EzM14COxMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>读取电子表格中单个指定范围的数据。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="range">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>查询范围。格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
    /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取</para>
    /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// <para>**注意**：若使用 `&lt;sheetId&gt;!&lt;开始单元格&gt;:&lt;结束列&gt;` 和 `&lt;sheetId&gt;!&lt;开始列&gt;:&lt;结束列&gt;` 的写法时，仅支持获取 100 列数据。</para>
    /// </param>
    /// <param name="valueRenderOption">
    /// <para>必填：否</para>
    /// <para>指定单元格数据的格式。可选值如下所示。当参数缺省时，默认不进行公式计算，返回公式本身，且单元格为数值格式。</para>
    /// <para>- ToString：返回纯文本的值（数值类型除外）</para>
    /// <para>- Formula：单元格中含有公式时，返回公式本身</para>
    /// <para>- FormattedValue：计算并格式化单元格</para>
    /// <para>- UnformattedValue：计算但不对单元格进行格式化</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dateTimeRenderOption">
    /// <para>必填：否</para>
    /// <para>指定数据类型为日期、时间、或时间日期的单元格数据的格式。</para>
    /// <para>- 若不传值，默认返回浮点数值，整数部分为自 1899 年 12 月 30 日以来的天数；小数部分为该时间占 24 小时的份额。例如：若时间为 1900 年 1 月 1 日中午 12 点，则默认返回 2.5。其中，2 表示 1900 年 1 月 1 日为 1899 年12 月 30 日之后的 2 天；0.5 表示 12 点占 24 小时的二分之一，即 12/24=0.5。</para>
    /// <para>- 可选值为 FormattedString，此时接口将计算并对日期、时间、或时间日期类型的数据格式化并返回格式化后的字符串，但不会对数字进行格式化。</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>当单元格中包含@用户等涉及用户信息的元素时，该参数可指定返回的用户 ID 类型。默认为 `lark_id`，建议选择 `open_id` 或 `union_id`。了解更多，参考[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。可选值：</para>
    /// <para>- `open_id`：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。了解更多：[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>- `union_id`：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。了解更多：[如何获取 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values/{range}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesByRangeResponseDto>> GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesByRangeAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string range,
        [PathQuery] string? valueRenderOption = null,
        [PathQuery] string? dateTimeRenderOption = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取旧版文档纯文本内容</para>
    /// <para>接口ID：6907569742384857090</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukzNzUjL5czM14SO3MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口只支持查询旧版文档纯文本内容。要查询新版文档（文档类型：`docx`）的纯文本内容，使用[获取文档纯文本内容](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/raw_content)接口。</para>
    /// </summary>
    /// <param name="docToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>获取方式详见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/doc/v2/{docToken}/raw_content")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDocV2ByDocTokenRawContentResponseDto>> GetDocV2ByDocTokenRawContentAsync(
        UserAccessToken access_token,
        [PathQuery] string docToken);

    /// <summary>
    /// <para>【云文档】合并单元格</para>
    /// <para>接口ID：6907569742387707906</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukDNzUjL5QzM14SO0MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>合并电子表格工作表中的单元格。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/merge_cells")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新工作表属性</para>
    /// <para>接口ID：6907569743419473922</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ugjMzUjL4IzM14COyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新电子表格中的工作表。支持更新工作表的标题、位置，和隐藏、冻结、保护等属性。</para>
    /// <para>该接口和 [操作工作表](https://open.feishu.cn/document/ukTMukTMukTM/uYTMzUjL2EzM14iNxMTN) 的请求地址相同，但参数不同，调用前请仔细阅读文档。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型。默认为 `lark_id`，建议选择 `open_id` 或 `union_id`。了解更多，参考[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。可选值：</para>
    /// <para>- `open_id`：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。了解更多：[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>- `union_id`：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。了解更多：[如何获取 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/sheets_batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2ResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2Async(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2BodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】新建文件</para>
    /// <para>接口ID：6907569743419932674</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uQTNzUjL0UzM14CN1MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在云空间指定文件夹中创建电子表格或者多维表格。</para>
    /// </summary>
    /// <param name="folderToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>指定新建文件所属的文件夹或云空间根目录的 token。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/explorer/v2/file/{folderToken}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDriveExplorerV2FileByFolderTokenResponseDto>> PostDriveExplorerV2FileByFolderTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string folderToken,
        [JsonContent] Ccm.Spec.PostDriveExplorerV2FileByFolderTokenBodyDto dto);

    /// <summary>
    /// <para>【云文档】插入行列</para>
    /// <para>接口ID：6907569743420194818</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uQjMzUjL0IzM14CNyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在电子表格的指定位置插入空白行或列。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/insert_dimension_range")]
    System.Threading.Tasks.Task<FeishuResponse> PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenInsertDimensionRangeBodyDto dto);

    /// <summary>
    /// <para>【云文档】读取多个范围</para>
    /// <para>接口ID：6907569743420325890</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukTMzUjL5EzM14SOxMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>读取电子表格中多个指定范围的数据。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="ranges">
    /// <para>必填：是</para>
    /// <para>多个查询范围，范围之间使用逗号分隔，如 `Q7PlXT!A2:B6,0b6377!B1:C8`。range 的格式为 `&lt;sheetId&gt;!&lt;开始位置&gt;:&lt;结束位置&gt;`。其中：</para>
    /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取</para>
    /// <para>- `&lt;开始位置&gt;:&lt;结束位置&gt;` 为工作表中单元格的范围，数字表示行索引，字母表示列索引。如 `A2:B2` 表示该工作表第 2 行的 A 列到 B 列。`range`支持四种写法，详情参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// <para>**注意**：若使用 `&lt;sheetId&gt;!&lt;开始单元格&gt;:&lt;结束列&gt;` 的写法时，仅支持获取 100 列数据。</para>
    /// </param>
    /// <param name="valueRenderOption">
    /// <para>必填：否</para>
    /// <para>指定单元格数据的格式。可选值如下所示。当参数缺省时，默认不进行公式计算，返回公式本身，且单元格为数值格式。</para>
    /// <para>- ToString：返回纯文本的值（数值类型除外）</para>
    /// <para>- Formula：单元格中含有公式时，返回公式本身</para>
    /// <para>- FormattedValue：计算并格式化单元格</para>
    /// <para>- UnformattedValue：计算但不对单元格进行格式化</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dateTimeRenderOption">
    /// <para>必填：否</para>
    /// <para>指定数据类型为日期、时间、或时间日期的单元格数据的格式。</para>
    /// <para>- 若不传值，默认返回浮点数值，整数部分为自 1899 年 12 月 30 日以来的天数；小数部分为该时间占 24 小时的份额。例如：若时间为 1900 年 1 月 1 日中午 12 点，则默认返回 2.5。其中，2 表示 1900 年 1 月 1 日为 1899 年12 月 30 日之后的 2 天；0.5 表示 12 点占 24 小时的二分之一，即 12/24=0.5。</para>
    /// <para>- 可选值为 FormattedString，此时接口将计算并对日期、时间、或时间日期类型的数据格式化并返回格式化后的字符串，但不会对数字进行格式化。</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>当单元格中包含@用户等涉及用户信息的元素时，该参数可指定返回的用户 ID 类型。默认为 `lark_id`，建议选择 `open_id` 或 `union_id`。了解更多，参考[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。可选值：</para>
    /// <para>- `open_id`：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。了解更多：[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>- `union_id`：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。了解更多：[如何获取 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values_batch_get")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto>> GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string ranges,
        [PathQuery] string? valueRenderOption = null,
        [PathQuery] string? dateTimeRenderOption = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取元数据</para>
    /// <para>接口ID：6907569743420637186</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uMjN3UjLzYzN14yM2cTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 token 获取各类文件的元数据。</para>
    /// <para>请求用户需要拥有该文件的访问（读）权限</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/suite/docs-api/meta")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSuiteDocsApiMetaResponseDto>> PostSuiteDocsApiMetaAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostSuiteDocsApiMetaBodyDto dto);

    /// <summary>
    /// <para>【云文档】转移拥有者</para>
    /// <para>接口ID：6907569744329719809</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uQzNzUjL0czM14CN3MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文档信息和用户信息转移文档的所有者。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/permission/member/transfer")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDrivePermissionMemberTransferResponseDto>> PostDrivePermissionMemberTransferAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostDrivePermissionMemberTransferBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取表格元数据</para>
    /// <para>接口ID：6907569744330227713</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uETMzUjLxEzM14SMxMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 spreadsheetToken 获取表格元数据。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token；获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="extFields">
    /// <para>必填：否</para>
    /// <para>额外返回的字段，extFields=protectedRange时返回保护行列信息</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>返回的用户id类型，可选open_id,union_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/metainfo")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoResponseDto>> GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string? extFields = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取旧版文档中的电子表格元数据</para>
    /// <para>接口ID：6907569744330833921</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uADOzUjLwgzM14CM4MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口只支持获取旧版文档数据。要获取新版文档（`docx` 类型）中的元数据，使用[获取文档元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/meta/batch_query)接口。</para>
    /// </summary>
    /// <param name="docToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>doc 的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/doc/v2/{docToken}/sheet_meta")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDocV2ByDocTokenSheetMetaResponseDto>> GetDocV2ByDocTokenSheetMetaAsync(
        UserAccessToken access_token,
        [PathQuery] string docToken);

    /// <summary>
    /// <para>【云文档】增加行列</para>
    /// <para>接口ID：6907569744333864961</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUjMzUjL1IzM14SNyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在电子表格工作表中增加空白行或列。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dimension_range")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeBodyDto dto);

    /// <summary>
    /// <para>【云文档】向单个范围写入数据</para>
    /// <para>接口ID：6907569745298980866</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uAjMzUjLwIzM14CMyMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>向电子表格某个工作表的单个指定范围中写入数据。若指定范围已内有数据，将被新写入的数据覆盖。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>**示例值**："Iow7sNNEphp3WbtnbCscPqabcef"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/values")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesResponseDto>> PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenValuesBodyDto dto);

    /// <summary>
    /// <para>【云文档】操作工作表</para>
    /// <para>接口ID：6907569745299439618</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYTMzUjL2EzM14iNxMTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据电子表格的 token 对工作表进行操作，包括增加工作表、复制工作表、删除工作表。</para>
    /// <para>该接口和 [更新工作表属性](https://open.feishu.cn/document/ukTMukTMukTM/ugjMzUjL4IzM14COyMTN) 的请求地址相同，但参数不同，调用前请仔细阅读文档。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Ios7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/sheets_batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateBodyDto dto);

    /// <summary>
    /// <para>【云文档】新建文件夹</para>
    /// <para>接口ID：6907569745299750914</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ukTNzUjL5UzM14SO1MTN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/create_folder)</para>
    /// <para>该接口用于根据 folderToken 在该 folder 下创建文件夹。</para>
    /// <para>该接口不支持并发创建，且调用频率上限为 5QPS 以及 10000次/天</para>
    /// </summary>
    /// <param name="folderToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件夹的 token，获取方式见 [概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/files/guide/introduction)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("迁移至新版本：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/create_folder")]
    [HttpPost("/open-apis/drive/explorer/v2/folder/{folderToken}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDriveExplorerV2FolderByFolderTokenResponseDto>> PostDriveExplorerV2FolderByFolderTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string folderToken,
        [JsonContent] Ccm.Spec.PostDriveExplorerV2FolderByFolderTokenBodyDto dto);

    /// <summary>
    /// <para>【云文档】编辑旧版文档内容</para>
    /// <para>接口ID：6908984614439813122</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYDM2YjL2AjN24iNwYjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口只支持编辑旧版文档内容。要编辑新版文档（文档类型：`docx`）的内容，调用以下接口：</para>
    /// <para>- [创建块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/create)</para>
    /// <para>- [更新块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/patch)</para>
    /// <para>- [批量更新块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/batch_update)</para>
    /// <para>- [删除块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/batch_delete)</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/doc/v2/{docToken}/batch_update")]
    System.Threading.Tasks.Task<FeishuResponse> PostDocV2ByDocTokenBatchUpdateAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostDocV2ByDocTokenBatchUpdateBodyDto dto);

    /// <summary>
    /// <para>【云文档】创建旧版文档</para>
    /// <para>接口ID：6908984614439829506</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ugDM2YjL4AjN24COwYjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口已废弃。要创建文档，使用[创建文档](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/create)接口。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("历史版本")]
    [HttpPost("/open-apis/doc/v2/create")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostDocV2CreateResponseDto>> PostDocV2CreateAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostDocV2CreateBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取旧版文档富文本内容</para>
    /// <para>接口ID：6908984614439845890</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDM2YjL1AjN24SNwYjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口只支持获取旧版文档富文本内容。要获取新版文档（文档类型：`docx`）的富文本内容，调用以下接口：</para>
    /// <para>- [获取文档所有块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/list)</para>
    /// <para>- [获取指定块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/get)</para>
    /// <para>- [获取指定块下所有子块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/get)</para>
    /// </summary>
    /// <param name="docToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>获取方式详见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/doc/v2/{docToken}/content")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDocV2ByDocTokenContentResponseDto>> GetDocV2ByDocTokenContentAsync(
        UserAccessToken access_token,
        [PathQuery] string docToken);

    /// <summary>
    /// <para>【身份验证】JSAPI 临时授权凭证</para>
    /// <para>接口ID：6911312738021720065</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/h5_js_sdk/authorization</para>
    /// <para>Authorization：app_access_token、tenant_access_token、user_access_token</para>
    /// <para>该接口用于返回调用 JSAPI 临时调用凭证，使用该凭证，在调用 JSAPI 时，请求不会被拦截</para>
    /// </summary>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/jssdk/ticket/get")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.Spec.PostJssdkTicketGetResponseDto>> PostJssdkTicketGetAsync(
        UserAccessToken access_token);

    /// <summary>
    /// <para>【视频会议】设置主持人</para>
    /// <para>接口ID：6921909217674805275</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/set_host</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>设置会议的主持人。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/vc/v1/meetings/{meeting_id}/set_host")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PatchVcV1MeetingsByMeetingIdSetHostResponseDto>> PatchVcV1MeetingsByMeetingIdSetHostAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id,
        [JsonContent] Vc.PatchVcV1MeetingsByMeetingIdSetHostBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】更新预约</para>
    /// <para>接口ID：6921909217674854427</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/reserve/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新一个预约。</para>
    /// </summary>
    /// <param name="reserve_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>预约ID（预约的唯一标识）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/vc/v1/reserves/{reserve_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PutVcV1ReservesByReserveIdResponseDto>> PutVcV1ReservesByReserveIdAsync(
        UserAccessToken access_token,
        [PathQuery] string reserve_id,
        [JsonContent] Vc.PutVcV1ReservesByReserveIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】获取预约</para>
    /// <para>接口ID：6921909217674936347</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/reserve/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个预约的详情。</para>
    /// </summary>
    /// <param name="reserve_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>预约ID（预约的唯一标识）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/reserves/{reserve_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1ReservesByReserveIdResponseDto>> GetVcV1ReservesByReserveIdAsync(
        UserAccessToken access_token,
        [PathQuery] string reserve_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】获取活跃会议</para>
    /// <para>接口ID：6921909217674952731</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/reserve/get_active_meeting</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个预约的当前活跃会议。</para>
    /// </summary>
    /// <param name="reserve_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>预约ID（预约的唯一标识）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="with_participants">
    /// <para>必填：否</para>
    /// <para>是否需要参会人列表，默认为false</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/reserves/{reserve_id}/get_active_meeting")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1ReservesByReserveIdGetActiveMeetingResponseDto>> GetVcV1ReservesByReserveIdGetActiveMeetingAsync(
        UserAccessToken access_token,
        [PathQuery] string reserve_id,
        [PathQuery] bool? with_participants = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取保护范围</para>
    /// <para>接口ID：6923123667871596572</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uQTM5YjL0ETO24CNxkjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据保护范围ID查询详细的保护行列信息，最多支持同时查询5个ID。</para>
    /// <para>1. 仅支持获取保护行或保护列，暂不支持获取保护单元格</para>
    /// <para>2. 不支持获取包含多个区域的保护范围</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="protectIds">
    /// <para>必填：是</para>
    /// <para>保护范围ID，可以通过[获取表格元数据](https://open.feishu.cn/document/ukTMukTMukTM/uETMzUjLxEzM14SMxMTN)接口获取，多个ID用逗号分隔，如xxxID1,xxxID2</para>
    /// </param>
    /// <param name="memberType">
    /// <para>必填：否</para>
    /// <para>返回的用户类型，可选userId,openId,unionId,默认使用userId</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/protected_range_batch_get")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetResponseDto>> GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string protectIds,
        [PathQuery] string? memberType = null);

    /// <summary>
    /// <para>【云文档】修改保护范围</para>
    /// <para>接口ID：6923123667871612956</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUTM5YjL1ETO24SNxkjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据保护范围ID修改保护范围，单次最多支持同时修改10个ID。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>sheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/protected_range_batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto dto);

    /// <summary>
    /// <para>【云文档】删除保护范围</para>
    /// <para>接口ID：6923123667871629340</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uYTM5YjL2ETO24iNxkjN</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据保护范围ID删除保护范围，最多支持同时删除10个ID。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>sheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/protected_range_batch_del")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelResponseDto>> DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelBodyDto dto);

    /// <summary>
    /// <para>【云文档】搜索 Wiki</para>
    /// <para>接口ID：6927492937392324635</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uEzN0YjLxcDN24SM3QjN/search_wiki</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>搜索 Wiki，用户通过关键词查询 Wiki，只能查找自己可见的 wiki</para>
    /// <para>**注：** Wiki 存在，但用户搜索不到并不一定是搜索有问题，可能是用户没有查看该 Wiki 的权限</para>
    /// </summary>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>下一页的分页 token，首页不需要填写，根据返回的 token 获取下一页数据</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>本页返回数量的最大值 0 &lt; page_size &lt;= 50 默认 20</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v1/nodes/search")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostWikiV1NodesSearchResponseDto>> PostWikiV1NodesSearchAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.Spec.PostWikiV1NodesSearchBodyDto dto,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 10);

    /// <summary>
    /// <para>【云文档】删除条件格式</para>
    /// <para>接口ID：6939784115499859996</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除已有的条件格式，单次最多支持删除10个条件格式，每个条件格式的删除会返回成功或者失败，失败的情况包括各种参数的校验。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>sheet 的 token，获取方式见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/condition_formats/batch_delete")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteResponseDto>> DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteBodyDto dto);

    /// <summary>
    /// <para>【云文档】创建条件格式</para>
    /// <para>接口ID：6939784115499892764</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-set</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于创建新的条件格式，单次最多支持增加10个条件格式，每个条件格式的设置会返回成功或者失败，失败的情况包括各种参数的校验。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/condition_formats/batch_create")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取条件格式</para>
    /// <para>接口ID：6939784115499909148</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据sheetId查询详细的条件格式信息，最多支持同时查询10个sheetId。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="sheet_ids">
    /// <para>必填：是</para>
    /// <para>工作表ID，可以通过[获取表格元数据](https://open.feishu.cn/document/ukTMukTMukTM/uETMzUjLxEzM14SMxMTN)接口获取，多个ID用逗号分隔，如xxxID1,xxxID2</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/condition_formats")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsResponseDto>> GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string[] sheet_ids);

    /// <summary>
    /// <para>【云文档】更新条件格式</para>
    /// <para>接口ID：6939784115499925532</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/conditionformat/condition-format-update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新已有的条件格式，单次最多支持更新10个条件格式，每个条件格式的更新会返回成功或者失败，失败的情况包括各种参数的校验。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>sheet 的 token，获取方式见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/condition_formats/batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateResponseDto>> PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateBodyDto dto);

    /// <summary>
    /// <para>【通讯录】获取父部门信息</para>
    /// <para>接口ID：6943913881476775963</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/parent</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用来递归获取部门父部门的信息，并按照由子到父的顺序返回有权限的父部门信息列表（不包含根部门）。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：用来标识租户内一个唯一的部门</item>
    /// <item>open_department_id：用来在具体某个应用中标识一个部门，同一个部门 在不同应用中的 open_department_id 不相同。</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="department_id">
    /// <para>必填：是</para>
    /// <para>部门ID</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ%2BG8JG6tK7%2BZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/departments/parent")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3DepartmentsParentResponseDto>> GetContactV3DepartmentsParentAsync(
        UserAccessToken access_token,
        [PathQuery] string department_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【通讯录】修改用户部分信息</para>
    /// <para>接口ID：6943913881476792347</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新通讯录中用户的字段，未传递的参数不会更新。</para>
    /// </summary>
    /// <param name="user_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>用户ID，需要与查询参数中的user_id_type类型保持一致。</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：以自定义department_id来标识部门</item>
    /// <item>open_department_id：以open_department_id来标识部门</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/contact/v3/users/{user_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.PatchContactV3UsersByUserIdResponseDto>> PatchContactV3UsersByUserIdAsync(
        UserAccessToken access_token,
        [PathQuery] string user_id,
        [JsonContent] Contact.PatchContactV3UsersByUserIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id");

    /// <summary>
    /// <para>【通讯录】搜索部门</para>
    /// <para>接口ID：6943913881476841499</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>搜索部门，用户通过关键词查询可见的部门数据，部门可见性需要管理员在后台配置。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：用来标识租户内一个唯一的部门</item>
    /// <item>open_department_id：用来在具体某个应用中标识一个部门，同一个部门 在不同应用中的 open_department_id 不相同。</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/contact/v3/departments/search")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.PostContactV3DepartmentsSearchResponseDto>> PostContactV3DepartmentsSearchAsync(
        UserAccessToken access_token,
        [JsonContent] Contact.PostContactV3DepartmentsSearchBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【通讯录】获取用户列表</para>
    /// <para>接口ID：6943913881476874267</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>基于部门ID获取部门下直属用户列表。</para>
    /// <para>[常见问题答疑](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN)。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>示例值：open_department_type</para>
    /// <list type="bullet">
    /// <item>department_id：以自定义department_id来标识部门</item>
    /// <item>open_department_id：以open_department_id来标识部门</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="department_id">
    /// <para>必填：否</para>
    /// <para>填写该字段表示获取部门下所有用户，选填。</para>
    /// <para>示例值：od-xxxxxxxxxxxxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS%2BJKiSIkdexPw=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/users")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3UsersResponseDto>> GetContactV3UsersAsync(
        UserAccessToken access_token,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] string? department_id = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【通讯录】获取单个用户信息</para>
    /// <para>接口ID：6943913881476956187</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取通讯录中单个用户的信息。</para>
    /// </summary>
    /// <param name="user_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>用户ID，类型需要与查询参数中的user_id_type保持一致。</para>
    /// <para>例如user_id_type=open_id，user_id的类型需为open_id</para>
    /// <para>不同ID的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>示例值：7be5fg9a</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>不同 ID 的说明 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：以自定义department_id来标识部门</item>
    /// <item>open_department_id：以open_department_id来标识部门</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/users/{user_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3UsersByUserIdResponseDto>> GetContactV3UsersByUserIdAsync(
        UserAccessToken access_token,
        [PathQuery] string user_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id");

    /// <summary>
    /// <para>【通讯录】获取部门信息列表</para>
    /// <para>接口ID：6943913881476972571</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取当前部门子部门列表。[常见问题答疑](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN)。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>**示例值**："open_id"</para>
    /// <para>**可选值有**：</para>
    /// <para>- `open_id`：用户的 open id</para>
    /// <para>- `union_id`：用户的 union id</para>
    /// <para>- `user_id`：用户的 user id</para>
    /// <para>**默认值**：`open_id`</para>
    /// <para>**当值为 `user_id`，字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee_id:readonly" desc="获取用户 user ID" support_app_types="custom" tags=""&gt;获取用户 user ID&lt;/md-perm&gt;</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>**示例值**："open_department_id"</para>
    /// <para>**可选值有**：</para>
    /// <para>- `department_id`：以自定义department_id来标识部门</para>
    /// <para>- `open_department_id`：以open_department_id来标识部门</para>
    /// <para>**默认值**：`open_department_id`</para>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="parent_department_id">
    /// <para>必填：否</para>
    /// <para>父部门的ID，填上获取部门下所有子部门，此处填写的 ID 必须是 department_id_type 指定的 ID。</para>
    /// <para>**示例值**："od-4e6ac4d14bcd5071a37a39de902c7141"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="fetch_child">
    /// <para>必填：否</para>
    /// <para>是否递归获取子部门</para>
    /// <para>**示例值**：是否递归获取子部门，默认值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>**示例值**："AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ%2BG8JG6tK7%2BZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>**示例值**：10</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最大值：`50`</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/departments")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.Spec.GetContactV3DepartmentsResponseDto>> GetContactV3DepartmentsAsync(
        UserAccessToken access_token,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] string? parent_department_id = null,
        [PathQuery] bool? fetch_child = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 10);

    /// <summary>
    /// <para>【通讯录】获取单个部门信息</para>
    /// <para>接口ID：6943913881476988955</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于向通讯录获取单个部门信息。</para>
    /// </summary>
    /// <param name="department_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要获取的部门ID</para>
    /// <para>不同 ID 的说明及获取方式 参见[部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：D096</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>不同 ID 的说明 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：用来标识租户内一个唯一的部门</item>
    /// <item>open_department_id：用来在具体某个应用中标识一个部门，同一个部门 在不同应用中的 open_department_id 相同。</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/departments/{department_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3DepartmentsByDepartmentIdResponseDto>> GetContactV3DepartmentsByDepartmentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string department_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id");

    /// <summary>
    /// <para>【云文档】删除下拉列表设置</para>
    /// <para>接口ID：6943917246700257282</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/datavalidation/delete-datavalidation</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口根据 spreadsheetToken 、range 移除选定数据范围单元格的下拉列表设置，但保留选项文本。单个删除范围不超过5000单元格。单次请求range最大数量100个。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dataValidation")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto>> DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto dto);

    /// <summary>
    /// <para>【云文档】设置下拉列表</para>
    /// <para>接口ID：6943917246700290050</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/datavalidation/set-dropdown</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口根据 spreadsheetToken 、range 和下拉列表属性给单元格设置下拉列表规则；单次设置范围不超过5000行，100列。当一个数据区域中已有数据，支持将有效数据直接转为选项。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dataValidation")]
    System.Threading.Tasks.Task<FeishuResponse> PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [JsonContent] Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto dto);

    /// <summary>
    /// <para>【云文档】查询下拉列表设置</para>
    /// <para>接口ID：6943917246700306434</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/datavalidation/query-datavalidation</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口根据 spreadsheetToken 、range 查询range内的下拉列表设置信息；单次查询范围不超过5000行，100列。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见 [在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="range">
    /// <para>必填：是</para>
    /// <para>查询范围，包含 sheetId 与单元格范围两部分，目前支持四种索引方式，详见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="dataValidationType">
    /// <para>必填：是</para>
    /// <para>固定为"list"，表示下拉列表</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dataValidation")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto>> GetSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string range,
        [PathQuery] string dataValidationType);

    /// <summary>
    /// <para>【云文档】更新下拉列表设置</para>
    /// <para>接口ID：6943917246700322818</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/datavalidation/update-datavalidation</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口根据 spreadsheetToken 、sheetId、dataValidationId 更新下拉列表的属性。</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// </param>
    /// <param name="sheetId">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子sheet唯一识别参数</para>
    /// </param>
    /// <param name="dataValidationId">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>sheet中下拉列表的唯一标示id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v2/spreadsheets/{spreadsheetToken}/dataValidation/{sheetId}/{dataValidationId}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdByDataValidationIdResponseDto>> PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdByDataValidationIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken,
        [PathQuery] string sheetId,
        [PathQuery] int dataValidationId,
        [JsonContent] Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBySheetIdByDataValidationIdBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】判断用户或机器人是否在群里</para>
    /// <para>接口ID：6946222929790418972</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/is_in_chat</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据使用的access_token判断对应的用户或者机器人是否在群里。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/{chat_id}/members/is_in_chat")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsByChatIdMembersIsInChatResponseDto>> GetImV1ChatsByChatIdMembersIsInChatAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id);

    /// <summary>
    /// <para>【消息与群组】获取群公告信息</para>
    /// <para>接口ID：6946222929790435356</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-announcement/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取会话中的群公告信息，公告信息格式与[旧版云文档](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)格式相同。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待获取公告的群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：不支持P2P单聊</para>
    /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/{chat_id}/announcement")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsByChatIdAnnouncementResponseDto>> GetImV1ChatsByChatIdAnnouncementAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】将用户或机器人移出群聊</para>
    /// <para>接口ID：6946222929790468124</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将用户或机器人移出群聊。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：仅支持群模式为`group`、`topic`的群组ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>app_id：飞书开放平台应用的唯一标识。在创建应用时，由系统自动生成，用户不能自行修改。[了解更多：如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/im/v1/chats/{chat_id}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Im.DeleteImV1ChatsByChatIdMembersResponseDto>> DeleteImV1ChatsByChatIdMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.DeleteImV1ChatsByChatIdMembersBodyDto dto,
        [PathQuery] string? member_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】获取群成员列表</para>
    /// <para>接口ID：6946222929790550044</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取用户/机器人所在群的群成员列表。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：以 open_id 来识别成员&lt;/md-enum-item&gt; **当值为 `user_id`，字段权限要求**： &lt;md-perm name="contact:user.employee_id:readonly" desc="获取用户 user ID" support_app_types="custom" tags=""&gt;获取用户 user ID&lt;/md-perm&gt; &lt;/md-td&gt; &lt;/md-tr&gt;</item>
    /// <item>union_id：以 union_id 来识别成员</item>
    /// <item>user_id：以 user_id 来识别成员</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20 **默认值**：`20` **数据校验规则**： - 最大值：`100`</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：WWxHTStrOEs5WHZpNktGbU94bUcvMWlxdDUzTWt1OXNrRmlLaGRNVG0yaz0=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/{chat_id}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsByChatIdMembersResponseDto>> GetImV1ChatsByChatIdMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [PathQuery] string? member_id_type = "open_id",
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【消息与群组】用户或机器人主动加入群聊</para>
    /// <para>接口ID：6946222929790631964</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/me_join</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>用户或机器人主动加入群聊。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：</para>
    /// <para>- 仅支持公开（Public）群类型</para>
    /// <para>- 对于已认证企业的飞书的群人数默认上限：普通群5000人，会议群3000人，话题群5000人</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/im/v1/chats/{chat_id}/members/me_join")]
    System.Threading.Tasks.Task<FeishuResponse> PatchImV1ChatsByChatIdMembersMeJoinAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id);

    /// <summary>
    /// <para>【消息与群组】搜索对用户或机器人可见的群列表</para>
    /// <para>接口ID：6946222929790648348</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/search</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据使用的 access_token 搜索对用户或机器人可见的群列表，包括：用户或机器人所在的群、对用户或机器人公开的群。</para>
    /// <para>搜索可获得的群信息包括：群ID（chat_id）、群名称、群描述等。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="query">
    /// <para>必填：否</para>
    /// <para>关键词</para>
    /// <para>**注意事项**：</para>
    /// <para>- 关键词支持匹配群国际化名称、群成员名称</para>
    /// <para>- 支持使用多语种搜索</para>
    /// <para>- 支持拼音、前缀等模糊搜索</para>
    /// <para>- 关键词为空值或长度超过`64`个字符时将返回空的结果</para>
    /// <para>示例值：abc</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/search")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsSearchResponseDto>> GetImV1ChatsSearchAsync(
        UserAccessToken access_token,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? query = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【消息与群组】撤回消息</para>
    /// <para>接口ID：6946222929790681116</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>机器人撤回机器人自己发送的消息或群主撤回群内消息。</para>
    /// </summary>
    /// <param name="message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待撤回的消息的ID</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/im/v1/messages/{message_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteImV1MessagesByMessageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string message_id);

    /// <summary>
    /// <para>【消息与群组】解散群</para>
    /// <para>接口ID：6946222931479396353</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>解散群组。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：仅支持群模式为`group`的群组ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/im/v1/chats/{chat_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteImV1ChatsByChatIdAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id);

    /// <summary>
    /// <para>【消息与群组】获取用户或机器人所在的群列表</para>
    /// <para>接口ID：6946222931479412737</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取 [access_token](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-choose-which-type-of-token-to-use) 所代表的用户或者机器人所在的群列表。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="sort_type">
    /// <para>必填：否</para>
    /// <para>群组排序方式</para>
    /// <para>示例值：ByCreateTimeAsc</para>
    /// <list type="bullet">
    /// <item>ByCreateTimeAsc：按群组创建时间升序排列</item>
    /// <item>ByActiveTimeDesc：按群组活跃时间降序排列</item>
    /// </list>
    /// <para>默认值：ByCreateTimeAsc</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsResponseDto>> GetImV1ChatsAsync(
        UserAccessToken access_token,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? sort_type = "ByCreateTimeAsc",
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【消息与群组】获取群信息</para>
    /// <para>接口ID：6946222931479478273</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取群名称、群描述、群头像、群主 ID 等群基本信息。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/{chat_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsByChatIdResponseDto>> GetImV1ChatsByChatIdAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】更新群公告信息</para>
    /// <para>接口ID：6946222931479511041</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-announcement/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新会话中的群公告信息，更新公告信息的格式和更新[旧版云文档](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)格式相同，不支持新版文档格式。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待修改公告的群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：不支持P2P单聊</para>
    /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/im/v1/chats/{chat_id}/announcement")]
    System.Threading.Tasks.Task<FeishuResponse> PatchImV1ChatsByChatIdAnnouncementAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PatchImV1ChatsByChatIdAnnouncementBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】更新应用发送的消息卡片</para>
    /// <para>接口ID：6946222931479543809</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新应用已发送的消息卡片内容。</para>
    /// </summary>
    /// <param name="message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待更新的消息的ID，仅支持更新消息卡片(`interactive`类型)，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/im/v1/messages/{message_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchImV1MessagesByMessageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string message_id,
        [JsonContent] Im.PatchImV1MessagesByMessageIdBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】更新群信息</para>
    /// <para>接口ID：6946222931479592961</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新群头像、群名称、群描述、群配置、转让群主等。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：仅支持群模式为`group`的群组ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/im/v1/chats/{chat_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PutImV1ChatsByChatIdAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PutImV1ChatsByChatIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】将用户或机器人拉入群聊</para>
    /// <para>接口ID：6946222931479609345</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-members/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将用户或机器人拉入群聊。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：仅支持群模式为`group`、`topic`的群组ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>app_id：飞书开放平台应用的唯一标识。在创建应用时，由系统自动生成，用户不能自行修改。[了解更多：如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="succeed_type">
    /// <para>必填：否</para>
    /// <para>出现不可用ID后的处理方式 0/1/2</para>
    /// <para>**默认值**：`0`</para>
    /// <para>示例值：0</para>
    /// <list type="bullet">
    /// <item>0：兼容之前的策略，不存在/不可见的 ID 会拉群失败，并返回错误响应。存在已离职 ID 时，会将其他可用 ID 拉入群聊，返回拉群成功的响应。</item>
    /// <item>1：将参数中可用的 ID 全部拉入群聊，返回拉群成功的响应，并展示剩余不可用的 ID 及原因。</item>
    /// <item>2：参数中只要存在任一不可用的 ID ，就会拉群失败，返回错误响应，并展示出不可用的 ID。</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdMembersResponseDto>> PostImV1ChatsByChatIdMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdMembersBodyDto dto,
        [PathQuery] string? member_id_type = "open_id",
        [PathQuery] int? succeed_type = null);

    /// <summary>
    /// <para>【消息与群组】获取群成员发言权限</para>
    /// <para>接口ID：6951292665602883586</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-moderation/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取群发言模式、可发言用户名单等。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：10</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/{chat_id}/moderation")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsByChatIdModerationResponseDto>> GetImV1ChatsByChatIdModerationAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【消息与群组】更新群发言权限</para>
    /// <para>接口ID：6951292665602899970</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-moderation/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新群组的发言权限设置，可设置为全员可发言、仅管理员可发言 或 指定用户可发言。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/im/v1/chats/{chat_id}/moderation")]
    System.Threading.Tasks.Task<FeishuResponse> PutImV1ChatsByChatIdModerationAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PutImV1ChatsByChatIdModerationBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】新增记录</para>
    /// <para>接口ID：6952707657162522626</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在数据表中新增一条记录</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：bascng7vrxcxpig7geggXiCtadY</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tblUa9vcYjWQYJCj</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>格式为标准的 uuidv4，操作的唯一标识，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdRecordsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? client_token = null);

    /// <summary>
    /// <para>【多维表格】更新多条记录</para>
    /// <para>接口ID：6952707657162539010</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/batch_update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新数据表中的多条记录，单次调用最多更新 500 条记录。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】删除记录</para>
    /// <para>接口ID：6952707657162555394</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除数据表中的一条记录</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="record_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>单条记录的Id</para>
    /// <para>示例值：recpCsf4ME</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/{record_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.DeleteBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto>> DeleteBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string record_id);

    /// <summary>
    /// <para>【多维表格】列出记录</para>
    /// <para>接口ID：6952707657162571778</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于列出数据表中的现有记录，单次最多列出 500 行记录，支持分页获取。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：bascnCMII2ORej2RItqpZZUNMIe</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tblxI2tWaxP5dG7p</para>
    /// </param>
    /// <param name="view_id">
    /// <para>必填：否</para>
    /// <para>视图的唯一标识符，获取指定视图下的记录[view_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>注意：</para>
    /// <para>当 filter 参数 或 sort 参数不为空时，请求视为对数据表中的全部数据做条件过滤，指定的view_id 会被忽略。</para>
    /// <para>示例值：vewqhz51lk</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="filter">
    /// <para>必填：否</para>
    /// <para>筛选参数，用于指定本次查询的筛选条件</para>
    /// <para>注意：</para>
    /// <para>1.不支持对“人员”以及“关联字段”的属性进行过滤筛选，如人员的 OpenID。</para>
    /// <para>2.指定筛选条件时，参数长度不超过2000个字符。</para>
    /// <para>详细请参考[筛选条件支持的公式](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/filter)</para>
    /// <para>示例值：AND(CurrentValue.[身高]&gt;180, CurrentValue.[体重]&gt;150)</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="sort">
    /// <para>必填：否</para>
    /// <para>排序参数，用于指定本次查询返回结果的顺序</para>
    /// <para>注意：</para>
    /// <para>1.不支持对带“公式”和“关联字段”的表的使用。</para>
    /// <para>2.指定排序条件时，参数长度不超过1000字符。</para>
    /// <para>3.当存在多个排序条件时，数据将根据条件顺序逐层排序</para>
    /// <para>示例值：["字段1 DESC","字段2 ASC"]</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="field_names">
    /// <para>必填：否</para>
    /// <para>字段名称，用于指定本次查询返回记录中包含的字段</para>
    /// <para>示例值：["字段1","字段2"]</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="text_field_as_array">
    /// <para>必填：否</para>
    /// <para>控制多行文本字段数据的返回格式，true 表示以数组形式返回。</para>
    /// <para>注意：</para>
    /// <para>1.多行文本中如果有超链接部分，则会返回链接的 URL。</para>
    /// <para>2.目前可以返回多行文本中 URL 类型为多维表格链接、飞书 doc、飞书 sheet的URL类型以及@人员的数据结构。</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="display_formula_ref">
    /// <para>必填：否</para>
    /// <para>默认值为false，返回当前字段的默认类型和结果；当该参数的值为true时，公式 和 查找引用 类型的字段，将会以 被引用字段 的格式返回</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="automatic_fields">
    /// <para>必填：否</para>
    /// <para>控制是否返回自动计算的字段，例如 `created_by`/`created_time`/`last_modified_by`/`last_modified_time`，true 表示返回</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：recn0hoyXL</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdRecordsResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdRecordsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string? view_id = null,
        [PathQuery] string? filter = null,
        [PathQuery] string? sort = null,
        [PathQuery] string? field_names = null,
        [PathQuery] bool? text_field_as_array = null,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] bool? display_formula_ref = null,
        [PathQuery] bool? automatic_fields = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【多维表格】检索记录</para>
    /// <para>接口ID：6952707657162588162</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 record_id 的值检索现有记录。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：bascnCMII2ORej2RItqpZZUNMIe</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblxI2tWaxP5dG7p</para>
    /// </param>
    /// <param name="record_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>单条记录的 id</para>
    /// <para>示例值：recn0hoyXL</para>
    /// </param>
    /// <param name="text_field_as_array">
    /// <para>必填：否</para>
    /// <para>多行文本字段数据是否以数组形式返回。true 表示以数组形式返回。默认为 false</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="display_formula_ref">
    /// <para>必填：否</para>
    /// <para>控制公式、查找引用是否显示完整原样的返回结果。默认为 false</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="with_shared_url">
    /// <para>必填：否</para>
    /// <para>控制是否返回该记录的链接，即 record_url 参数。默认为 false，即不返回</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="automatic_fields">
    /// <para>必填：否</para>
    /// <para>控制是否返回自动计算的字段，例如 `created_by`/`created_time`/`last_modified_by`/`last_modified_time`，true 表示返回。默认为 false</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/{record_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string record_id,
        [PathQuery] bool? text_field_as_array = null,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] bool? display_formula_ref = null,
        [PathQuery] bool? with_shared_url = null,
        [PathQuery] bool? automatic_fields = null);

    /// <summary>
    /// <para>【多维表格】新增多条记录</para>
    /// <para>接口ID：6952707657162604546</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/batch_create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在数据表中新增多条记录，单次调用最多新增 500 条记录。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>格式为标准的 uuidv4，操作的唯一标识，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/batch_create")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? client_token = null);

    /// <summary>
    /// <para>【多维表格】删除多条记录</para>
    /// <para>接口ID：6952707657162620930</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/batch_delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除数据表中现有的多条记录，单次调用中最多删除 500 条记录。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/batch_delete")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteBodyDto dto);

    /// <summary>
    /// <para>【多维表格】更新记录</para>
    /// <para>接口ID：6952707657162637314</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新数据表中的一条记录</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="record_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>一条记录的唯一标识 id [record_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#15d8db94)</para>
    /// <para>示例值：recqwIwhc6</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/{record_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto>> PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string record_id,
        [JsonContent] Base.PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】获取日程</para>
    /// <para>接口ID：6952888507002699803</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）获取指定日历内的某一日程信息，包括日程的标题、时间段、视频会议信息、公开范围以及参与人权限等。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：xxxxxxxxx_0</para>
    /// </param>
    /// <param name="need_meeting_settings">
    /// <para>必填：否</para>
    /// <para>是否需要返回飞书视频会议（VC）的会前设置。需满足以下条件才可以获取到返回结果：</para>
    /// <para>- 日程的会议类型（vc_type）需要是 vc。</para>
    /// <para>- 需要有日程的编辑权限。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：需要</para>
    /// <para>- false（默认值）：不需要</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="need_attendee">
    /// <para>必填：否</para>
    /// <para>是否需要返回参与人信息。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：需要</para>
    /// <para>- false（默认值）：不需要</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="max_attendee_num">
    /// <para>必填：否</para>
    /// <para>返回的最大参与人数量。调用[获取日程参与人列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/list)可获取日程完整的参与人信息。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdResponseDto>> GetCalendarV4CalendarsByCalendarIdEventsByEventIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [PathQuery] bool? need_meeting_settings = null,
        [PathQuery] bool? need_attendee = null,
        [PathQuery] int? max_attendee_num = 10,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】订阅日程变更事件</para>
    /// <para>接口ID：6952888507002716187</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/subscription</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口以用户身份订阅指定日历下的日程变更事件。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/subscription")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdEventsSubscriptionAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】订阅日历</para>
    /// <para>接口ID：6952888507002748955</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/subscribe</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）订阅指定的日历。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/subscribe")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsByCalendarIdSubscribeResponseDto>> PostCalendarV4CalendarsByCalendarIdSubscribeAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】获取日程列表</para>
    /// <para>接口ID：6952888507002798107</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）获取指定日历下的日程列表。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次请求要求返回的最大日程数量。</para>
    /// <para>示例值：50</para>
    /// <para>默认值：500</para>
    /// </param>
    /// <param name="anchor_time">
    /// <para>必填：否</para>
    /// <para>时间锚点，Unix 时间戳（秒）。anchor_time用于设置一个时间点，以便直接拉取该时间点之后的日程数据，从而避免拉取全量日程数据。你可以使用page_token或sync_token进行分页或增量拉取anchor_time之后的所有日程数据。</para>
    /// <para>- 不可与start_time和end_time一起使用。</para>
    /// <para>**默认值**：空</para>
    /// <para>示例值：1609430400</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：ListCalendarsPageToken_1632452910_1632539310</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="sync_token">
    /// <para>必填：否</para>
    /// <para>增量同步标记，第一次请求不填。当分页查询结束（page_token 返回值为空）时，接口会返回 sync_token 字段，下次调用可使用该 sync_token 增量获取日历变更数据。</para>
    /// <para>**默认值**：空</para>
    /// <para>示例值：ListCalendarsSyncToken_1632452910</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="start_time">
    /// <para>必填：否</para>
    /// <para>时间区间的开始时间， Unix 时间戳（秒），与end_time搭配使用，用于拉取指定时间区间内的日程数据.</para>
    /// <para>- 该方式只能一次性返回数据，无法进行分页。一次性返回的数据大小受page_size限制，超过限制的数据将被截断。</para>
    /// <para>- 在使用start_time和end_time时不能与page_token或sync_token一起使用。</para>
    /// <para>**默认值**：空</para>
    /// <para>示例值：1631777271</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：否</para>
    /// <para>时间区间的结束时间， Unix 时间戳（秒）。与start_time搭配使用，用于拉取指定时间区间内的日程数据.</para>
    /// <para>- 该方式只能一次性返回数据，无法进行分页。一次性返回的数据大小受page_size限制，超过限制的数据将被截断。</para>
    /// <para>- 在使用start_time和end_time时不能与page_token或sync_token一起使用。</para>
    /// <para>**默认值**：空</para>
    /// <para>示例值：1631777271</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/events")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdEventsResponseDto>> GetCalendarV4CalendarsByCalendarIdEventsAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] int? page_size = 500,
        [PathQuery] string? anchor_time = null,
        [PathQuery] string? page_token = null,
        [PathQuery] string? sync_token = null,
        [PathQuery] string? start_time = null,
        [PathQuery] string? end_time = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】创建访问控制</para>
    /// <para>接口ID：6952888507002814491</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）为指定日历添加访问控制，即日历成员权限。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要添加访问控制的日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/acls")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsByCalendarIdAclsResponseDto>> PostCalendarV4CalendarsByCalendarIdAclsAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [JsonContent] Calendar.PostCalendarV4CalendarsByCalendarIdAclsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】删除日程参与人</para>
    /// <para>接口ID：6952888507002830875</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/batch_delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）删除指定日程的一个或多个参与人。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程对应的日历 ID。了解更多，参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：xxxxxxxxx_0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/attendees/batch_delete")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBatchDeleteAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [JsonContent] Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBatchDeleteBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】获取日程参与群成员列表</para>
    /// <para>接口ID：6952888507002847259</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee-chat_member/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）获取日程的群组类型参与人的群成员列表。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：xxxxxxxxx_0</para>
    /// </param>
    /// <param name="attendee_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群组类型参与人 ID。</para>
    /// <para>添加日程参与人时，会返回参与人 ID（attendee_id），你也可以调用[获取日程参与人列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/list)接口，查询指定日程的参与人 ID。</para>
    /// <para>示例值：chat_xxxxxx</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：23jhysaxxxxsysy</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次请求返回的最大群成员数量。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/attendees/{attendee_id}/chat_members")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesByAttendeeIdChatMembersResponseDto>> GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesByAttendeeIdChatMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [PathQuery] string attendee_id,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】搜索日历</para>
    /// <para>接口ID：6952888507002863643</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口通过关键字搜索日历，搜索结果为标题或描述包含关键字的公共日历或用户主日历。</para>
    /// </summary>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：10</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次请求返回的最大日历数量。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/search")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsSearchResponseDto>> PostCalendarV4CalendarsSearchAsync(
        UserAccessToken access_token,
        [JsonContent] Calendar.PostCalendarV4CalendarsSearchBodyDto dto,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【日历】查询日历列表</para>
    /// <para>接口ID：6952888507002880027</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口分页查询当前身份（应用或用户）的日历列表。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次请求返回的最大日历数量。</para>
    /// <para>示例值：`50`</para>
    /// <para>默认值：500</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：ListCalendarsPageToken_xxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="sync_token">
    /// <para>必填：否</para>
    /// <para>增量同步标记，第一次请求不填。当分页查询结束（page_token 返回值为空）时，接口会返回 sync_token 字段，下次调用可使用该 sync_token 增量获取日历变更数据。</para>
    /// <para>**默认值**：空</para>
    /// <para>示例值：ListCalendarsSyncToken_xxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsResponseDto>> GetCalendarV4CalendarsAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 500,
        [PathQuery] string? page_token = null,
        [PathQuery] string? sync_token = null);

    /// <summary>
    /// <para>【日历】获取日程参与人列表</para>
    /// <para>接口ID：6952888507002896411</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）获取日程的参与人列表。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：xxxxxxxxx_0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="need_resource_customization">
    /// <para>必填：否</para>
    /// <para>是否需要会议室表单信息。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：需要</para>
    /// <para>- false（默认值）：不需要</para>
    /// <para>**注意**：当前身份需要有日程的编辑权限才会返回会议室表单信息，即当前身份需要是日程的组织者，或者是日程参与人且日程设置了**参与人可编辑日程**权限。你可以调用[获取日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/get)接口，获取日程的参与人权限（attendee_ability）。</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：780TRhwXXXXX</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次请求返回的最大日程参与人数量。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/attendees")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto>> GetCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] bool? need_resource_customization = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【日历】查询主日历日程忙闲信息</para>
    /// <para>接口ID：6952888507002912795</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/freebusy/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口查询指定用户的主日历忙闲信息，或者查询指定会议室的忙闲信息。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/freebusy/list")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4FreebusyListResponseDto>> PostCalendarV4FreebusyListAsync(
        UserAccessToken access_token,
        [JsonContent] Calendar.PostCalendarV4FreebusyListBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】生成 CalDAV 配置</para>
    /// <para>接口ID：6952888507002929179</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/setting/generate_caldav_conf</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>用于为当前用户生成一个CalDAV账号密码，用于将飞书日历信息同步到本地设备日历。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/settings/generate_caldav_conf")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.Spec.PostCalendarV4SettingsGenerateCaldavConfResponseDto>> PostCalendarV4SettingsGenerateCaldavConfAsync(
        UserAccessToken access_token,
        [JsonContent] Calendar.Spec.PostCalendarV4SettingsGenerateCaldavConfBodyDto dto);

    /// <summary>
    /// <para>【日历】删除访问控制</para>
    /// <para>接口ID：6952888507002945563</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）删除指定日历内的某一访问控制，即成员权限。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要删除访问控制的日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="acl_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>访问控制 ID。</para>
    /// <para>为日历创建访问控制时会返回访问控制 ID。你也可以调用[获取访问控制列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/list)接口，获取指定日历内的访问控制信息。</para>
    /// <para>示例值：user_xxxxxx</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/calendar/v4/calendars/{calendar_id}/acls/{acl_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteCalendarV4CalendarsByCalendarIdAclsByAclIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string acl_id);

    /// <summary>
    /// <para>【日历】删除日程</para>
    /// <para>接口ID：6952888507002961947</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）删除指定日历上的一个日程。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。了解更多，参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：xxxxxxxxx_0</para>
    /// </param>
    /// <param name="need_notification">
    /// <para>必填：否</para>
    /// <para>删除日程是否给日程参与人发送 Bot 通知。</para>
    /// <para>**默认值**：true</para>
    /// <para>示例值：false</para>
    /// <list type="bullet">
    /// <item>true：发送</item>
    /// <item>false：不发送</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteCalendarV4CalendarsByCalendarIdEventsByEventIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [PathQuery] bool? need_notification = null);

    /// <summary>
    /// <para>【日历】查询日历信息</para>
    /// <para>接口ID：6952888507002978331</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）查询指定日历的信息。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdResponseDto>> GetCalendarV4CalendarsByCalendarIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】删除共享日历</para>
    /// <para>接口ID：6952888507002994715</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）删除某一指定的共享日历。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/calendar/v4/calendars/{calendar_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteCalendarV4CalendarsByCalendarIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】订阅日历访问控制变更事件</para>
    /// <para>接口ID：6952888507003027483</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/subscription</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口以用户身份订阅指定日历下的访问控制变更事件。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/acls/subscription")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdAclsSubscriptionAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】更新日程</para>
    /// <para>接口ID：6952888507003043867</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）更新指定日历上的一个日程，包括日程标题、描述、开始与结束时间、视频会议以及日程地点等信息。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。了解更多，参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：00592a0e-7edf-4678-bc9d-1b77383ef08e_0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PatchCalendarV4CalendarsByCalendarIdEventsByEventIdResponseDto>> PatchCalendarV4CalendarsByCalendarIdEventsByEventIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [JsonContent] Calendar.PatchCalendarV4CalendarsByCalendarIdEventsByEventIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】订阅日历变更事件</para>
    /// <para>接口ID：6952888507003060251</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/subscription</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口为当前用户身份订阅[日历变更事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/events/changed)。</para>
    /// </summary>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/subscription")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsSubscriptionAsync(
        UserAccessToken access_token);

    /// <summary>
    /// <para>【日历】创建共享日历</para>
    /// <para>接口ID：6952888507003076635</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口为当前身份（应用或用户）创建一个共享日历。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsResponseDto>> PostCalendarV4CalendarsAsync(
        UserAccessToken access_token,
        [JsonContent] Calendar.PostCalendarV4CalendarsBodyDto dto);

    /// <summary>
    /// <para>【日历】取消订阅日历</para>
    /// <para>接口ID：6952888507003093019</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/unsubscribe</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）取消指定日历的订阅状态。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。</para>
    /// <para>你可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/unsubscribe")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdUnsubscribeAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】搜索日程</para>
    /// <para>接口ID：6952888507003109403</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以用户身份搜索指定日历下的相关日程。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：xxxxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次调用所返回的最大日程数量。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/search")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsByCalendarIdEventsSearchResponseDto>> PostCalendarV4CalendarsByCalendarIdEventsSearchAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [JsonContent] Calendar.PostCalendarV4CalendarsByCalendarIdEventsSearchBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【日历】添加日程参与人</para>
    /// <para>接口ID：6952888507003125787</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-attendee/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）为指定日程添加一个或多个参与人，参与人类型包括用户、群组、会议室以及邮箱。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程对应的日历 ID。了解更多，参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：xxxxxxxxx_0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/attendees")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesResponseDto>> PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [JsonContent] Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】更新日历信息</para>
    /// <para>接口ID：6952888507003158555</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）修改指定日历的标题、描述、公开范围等信息。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/calendar/v4/calendars/{calendar_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PatchCalendarV4CalendarsByCalendarIdResponseDto>> PatchCalendarV4CalendarsByCalendarIdAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [JsonContent] Calendar.PatchCalendarV4CalendarsByCalendarIdBodyDto dto);

    /// <summary>
    /// <para>【日历】获取访问控制列表</para>
    /// <para>接口ID：6953067803433009153</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）获取指定日历的访问控制列表。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：xxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小，即一次请求返回的最大条目数。</para>
    /// <para>**注意**：最小值 10，即取值小于 10 时统一按 10 处理。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/acls")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdAclsResponseDto>> GetCalendarV4CalendarsByCalendarIdAclsAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【邮箱】查询所有公共邮箱</para>
    /// <para>接口ID：6954915601882955779</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/public_mailbox/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>分页批量获取公共邮箱列表。</para>
    /// </summary>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：xxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/mail/v1/public_mailboxes")]
    System.Threading.Tasks.Task<FeishuResponse<Mail.GetMailV1PublicMailboxesResponseDto>> GetMailV1PublicMailboxesAsync(
        UserAccessToken access_token,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【云文档】删除回复</para>
    /// <para>接口ID：6955017385137717249</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除云文档中的某条回复。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档 Token</para>
    /// <para>示例值：doxbcdl03Vsxhm7Qmnj110abcef</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论 ID</para>
    /// <para>示例值：6916106822734578184</para>
    /// </param>
    /// <param name="reply_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>回复 ID</para>
    /// <para>示例值：6916106822734594568</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：表格</item>
    /// <item>file：文件</item>
    /// <item>docx：新版文档</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/drive/v1/files/{file_token}/comments/{comment_id}/replies/{reply_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteDriveV1FilesByFileTokenCommentsByCommentIdRepliesByReplyIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string comment_id,
        [PathQuery] string reply_id,
        [PathQuery] string file_type);

    /// <summary>
    /// <para>【云文档】更新回复的内容</para>
    /// <para>接口ID：6955017385137733633</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新云文档中的某条回复的内容。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档 Token</para>
    /// <para>示例值：doxbcdl03Vsxhm7Qmnj110abcef</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论 ID</para>
    /// <para>示例值：6916106822734578184</para>
    /// </param>
    /// <param name="reply_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>回复 ID</para>
    /// <para>示例值：6916106822734594568</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：表格</item>
    /// <item>file：文件</item>
    /// <item>docx：新版文档</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/drive/v1/files/{file_token}/comments/{comment_id}/replies/{reply_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PutDriveV1FilesByFileTokenCommentsByCommentIdRepliesByReplyIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string comment_id,
        [PathQuery] string reply_id,
        [PathQuery] string file_type,
        [JsonContent] Ccm.PutDriveV1FilesByFileTokenCommentsByCommentIdRepliesByReplyIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】添加全文评论</para>
    /// <para>接口ID：6955017385137750017</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在文档中添加一条全局评论，不支持局部评论。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档 Token</para>
    /// <para>可以通过浏览器该文档的 URL 栏上直接获取文档 Token 。</para>
    /// <para>示例值：XIHSdYSI7oMEU1xrsnxc8fabcef</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>docx：新版文档</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/comments")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesByFileTokenCommentsResponseDto>> PostDriveV1FilesByFileTokenCommentsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [JsonContent] Ccm.PostDriveV1FilesByFileTokenCommentsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】解决/恢复评论</para>
    /// <para>接口ID：6955017385137766401</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>解决或恢复云文档中的评论。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doccnGp4UK1UskrOEJwBXd3****</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论ID</para>
    /// <para>示例值：6916106822734578184</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：表格</item>
    /// <item>file：文件</item>
    /// <item>docx：新版文档</item>
    /// </list>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/drive/v1/files/{file_token}/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchDriveV1FilesByFileTokenCommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string comment_id,
        [PathQuery] string file_type,
        [JsonContent] Ccm.PatchDriveV1FilesByFileTokenCommentsByCommentIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取全文评论</para>
    /// <para>接口ID：6955017385137782785</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取云文档中的某条全文评论，不支持局部评论。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档 Token</para>
    /// <para>示例值：doccnHh7U87HOFpii5u5G*****</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论 ID</para>
    /// <para>示例值：6916106822734578184</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：表格</item>
    /// <item>file：文件</item>
    /// <item>docx：新版文档</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenCommentsByCommentIdResponseDto>> GetDriveV1FilesByFileTokenCommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string comment_id,
        [PathQuery] string file_type,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取云文档所有评论</para>
    /// <para>接口ID：6955017385137799169</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据云文档 Token 分页获取文档所有评论信息，包括评论和回复 ID、回复的内容、评论人和回复人的用户 ID 等。该接口支持返回全局评论以及局部评论（可通过 is_whole 字段区分）。默认每页返回 50 个评论。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>云文档 Token</para>
    /// <para>可以通过浏览器该文档的 URL 栏上直接获取云文档 Token 。</para>
    /// <para>示例值：XIHSdYSI7oMEU1xrsnxc8fabcef</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>file：文件类型</item>
    /// <item>docx：新版文档类型</item>
    /// </list>
    /// </param>
    /// <param name="is_whole">
    /// <para>必填：否</para>
    /// <para>是否全文评论</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="is_solved">
    /// <para>必填：否</para>
    /// <para>是否已解决（可选）</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：7153511712153412356</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小，默认每页返回 50 个评论</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/comments")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenCommentsResponseDto>> GetDriveV1FilesByFileTokenCommentsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [PathQuery] bool? is_whole = null,
        [PathQuery] bool? is_solved = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【服务台】创建客服技能</para>
    /// <para>接口ID：6955768425688268803</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent_skill/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于创建客服技能。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/agent_skills")]
    System.Threading.Tasks.Task<FeishuResponse<Helpdesk.PostHelpdeskV1AgentSkillsResponseDto>> PostHelpdeskV1AgentSkillsAsync(
        UserAccessToken access_token,
        [JsonContent] Helpdesk.PostHelpdeskV1AgentSkillsBodyDto dto);

    /// <summary>
    /// <para>【服务台】创建客服工作日程</para>
    /// <para>接口ID：6955768425688334339</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent_schedule/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于创建客服日程。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/agent_schedules")]
    System.Threading.Tasks.Task<FeishuResponse> PostHelpdeskV1AgentSchedulesAsync(
        UserAccessToken access_token,
        [JsonContent] Helpdesk.PostHelpdeskV1AgentSchedulesBodyDto dto);

    /// <summary>
    /// <para>【服务台】删除客服技能</para>
    /// <para>接口ID：6955768425688367107</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent_skill/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于删除客服技能。</para>
    /// </summary>
    /// <param name="agent_skill_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>agent group id</para>
    /// <para>示例值：test-skill-id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/helpdesk/v1/agent_skills/{agent_skill_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteHelpdeskV1AgentSkillsByAgentSkillIdAsync(
        UserAccessToken access_token,
        [PathQuery] string agent_skill_id);

    /// <summary>
    /// <para>【服务台】更新客服技能</para>
    /// <para>接口ID：6955768425688416259</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent_skill/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于更新客服技能。</para>
    /// </summary>
    /// <param name="agent_skill_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>agent skill id</para>
    /// <para>示例值：test-skill-id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/agent_skills/{agent_skill_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1AgentSkillsByAgentSkillIdAsync(
        UserAccessToken access_token,
        [PathQuery] string agent_skill_id,
        [JsonContent] Helpdesk.PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDto dto);

    /// <summary>
    /// <para>【服务台】删除客服工作日程</para>
    /// <para>接口ID：6955768425688432643</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent-schedules/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于删除客服日程。</para>
    /// </summary>
    /// <param name="agent_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>agent user id</para>
    /// <para>示例值：12345</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/helpdesk/v1/agents/{agent_id}/schedules")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteHelpdeskV1AgentsByAgentIdSchedulesAsync(
        UserAccessToken access_token,
        [PathQuery] string agent_id);

    /// <summary>
    /// <para>【服务台】更新客服工作日程</para>
    /// <para>接口ID：6955768425688514563</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent-schedules/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于更新客服的日程。</para>
    /// </summary>
    /// <param name="agent_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>客服 id</para>
    /// <para>示例值：123456</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/agents/{agent_id}/schedules")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1AgentsByAgentIdSchedulesAsync(
        UserAccessToken access_token,
        [PathQuery] string agent_id,
        [JsonContent] Helpdesk.PatchHelpdeskV1AgentsByAgentIdSchedulesBodyDto dto);

    /// <summary>
    /// <para>【服务台】创建工单自定义字段</para>
    /// <para>接口ID：6955768699895562242</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket_customized_field/create-ticket-customized-field</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于创建自定义字段。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/ticket_customized_fields")]
    System.Threading.Tasks.Task<FeishuResponse> PostHelpdeskV1TicketCustomizedFieldsAsync(
        UserAccessToken access_token,
        [JsonContent] Helpdesk.Spec.PostHelpdeskV1TicketCustomizedFieldsBodyDto dto);

    /// <summary>
    /// <para>【服务台】更新知识库分类详情</para>
    /// <para>接口ID：6955768699895595010</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/category/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于更新知识库分类详情。</para>
    /// </summary>
    /// <param name="id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>category id</para>
    /// <para>示例值：6948728206392295444</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/categories/{id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1CategoriesByIdAsync(
        UserAccessToken access_token,
        [PathQuery] string id,
        [JsonContent] Helpdesk.PatchHelpdeskV1CategoriesByIdBodyDto dto);

    /// <summary>
    /// <para>【服务台】删除工单自定义字段</para>
    /// <para>接口ID：6955768699895644162</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket_customized_field/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于删除工单自定义字段。</para>
    /// </summary>
    /// <param name="ticket_customized_field_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工单自定义字段ID</para>
    /// <para>示例值：6948728206392295444</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/helpdesk/v1/ticket_customized_fields/{ticket_customized_field_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdAsync(
        UserAccessToken access_token,
        [PathQuery] string ticket_customized_field_id);

    /// <summary>
    /// <para>【服务台】更新工单自定义字段</para>
    /// <para>接口ID：6955768699895660546</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket_customized_field/update-ticket-customized-field</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于更新自定义字段。</para>
    /// </summary>
    /// <param name="ticket_customized_field_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工单自定义字段ID</para>
    /// <para>**示例值**："6948728206392295444"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/ticket_customized_fields/{ticket_customized_field_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdAsync(
        UserAccessToken access_token,
        [PathQuery] string ticket_customized_field_id,
        [JsonContent] Helpdesk.Spec.PatchHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdBodyDto dto);

    /// <summary>
    /// <para>【服务台】修改知识库</para>
    /// <para>接口ID：6955768699895676930</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/faq/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于修改知识库。</para>
    /// </summary>
    /// <param name="id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识库ID</para>
    /// <para>示例值：6856395634652479491</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/faqs/{id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1FaqsByIdAsync(
        UserAccessToken access_token,
        [PathQuery] string id,
        [JsonContent] Helpdesk.PatchHelpdeskV1FaqsByIdBodyDto dto);

    /// <summary>
    /// <para>【服务台】创建知识库分类</para>
    /// <para>接口ID：6955768699895775234</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/category/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于创建知识库分类。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/categories")]
    System.Threading.Tasks.Task<FeishuResponse<Helpdesk.PostHelpdeskV1CategoriesResponseDto>> PostHelpdeskV1CategoriesAsync(
        UserAccessToken access_token,
        [JsonContent] Helpdesk.PostHelpdeskV1CategoriesBodyDto dto);

    /// <summary>
    /// <para>【服务台】创建知识库</para>
    /// <para>接口ID：6955768699895791618</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/faq/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于创建知识库。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/faqs")]
    System.Threading.Tasks.Task<FeishuResponse<Helpdesk.PostHelpdeskV1FaqsResponseDto>> PostHelpdeskV1FaqsAsync(
        UserAccessToken access_token,
        [JsonContent] Helpdesk.PostHelpdeskV1FaqsBodyDto dto);

    /// <summary>
    /// <para>【服务台】更新工单详情</para>
    /// <para>接口ID：6955768699895824386</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/update</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于更新服务台工单详情。只会更新数据，不会触发相关操作。如修改工单状态到关单，不会关闭聊天页面。仅支持自建应用。要更新的工单字段必须至少输入一项。</para>
    /// </summary>
    /// <param name="ticket_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工单ID</para>
    /// <para>示例值：6945345902185807891</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/helpdesk/v1/tickets/{ticket_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PutHelpdeskV1TicketsByTicketIdAsync(
        UserAccessToken access_token,
        [PathQuery] string ticket_id,
        [JsonContent] Helpdesk.PutHelpdeskV1TicketsByTicketIdBodyDto dto);

    /// <summary>
    /// <para>【服务台】删除知识库</para>
    /// <para>接口ID：6955768699895922690</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/faq/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于删除知识库。</para>
    /// </summary>
    /// <param name="id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>id</para>
    /// <para>示例值：12345</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/helpdesk/v1/faqs/{id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteHelpdeskV1FaqsByIdAsync(
        UserAccessToken access_token,
        [PathQuery] string id);

    /// <summary>
    /// <para>【服务台】删除知识库分类详情</para>
    /// <para>接口ID：6955768699895971842</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/category/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口用于删除知识库分类详情。</para>
    /// </summary>
    /// <param name="id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识库分类ID</para>
    /// <para>示例值：6948728206392295444</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/helpdesk/v1/categories/{id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteHelpdeskV1CategoriesByIdAsync(
        UserAccessToken access_token,
        [PathQuery] string id);

    /// <summary>
    /// <para>【多维表格】新增字段</para>
    /// <para>接口ID：6960166873968427011</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在数据表中新增一个字段</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>格式为标准的 uuidv4，操作的唯一标识，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/fields")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdFieldsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdFieldsBodyDto dto,
        [PathQuery] string? client_token = null);

    /// <summary>
    /// <para>【多维表格】删除一个数据表</para>
    /// <para>接口ID：6960166873968443395</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除一个数据表，最后一张数据表不允许被删除。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteBitableV1AppsByAppTokenTablesByTableIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id);

    /// <summary>
    /// <para>【多维表格】删除多个数据表</para>
    /// <para>接口ID：6960166873968459779</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/batch_delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除多个数据表。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/batch_delete")]
    System.Threading.Tasks.Task<FeishuResponse> PostBitableV1AppsByAppTokenTablesBatchDeleteAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesBatchDeleteBodyDto dto);

    /// <summary>
    /// <para>【多维表格】列出数据表</para>
    /// <para>接口ID：6960166873968476163</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 app_token，获取多维表格下的所有数据表。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesResponseDto>> GetBitableV1AppsByAppTokenTablesAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【多维表格】列出字段</para>
    /// <para>接口ID：6960166873968492547</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 app_token 和 table_id，获取数据表的所有字段</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="view_id">
    /// <para>必填：否</para>
    /// <para>视图 ID</para>
    /// <para>示例值：vewOVMEXPF</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="text_field_as_array">
    /// <para>必填：否</para>
    /// <para>控制字段描述（多行文本格式）数据的返回格式, true 表示以数组富文本形式返回</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：fldwJ4YrtB</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/fields")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdFieldsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string? view_id = null,
        [PathQuery] bool? text_field_as_array = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【多维表格】更新字段</para>
    /// <para>接口ID：6960166873968508931</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在数据表中更新一个字段</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="field_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>field id</para>
    /// <para>示例值：fldPTb0U2y</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/fields/{field_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PutBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto>> PutBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string field_id,
        [JsonContent] Base.PutBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdBodyDto dto);

    /// <summary>
    /// <para>【多维表格】删除字段</para>
    /// <para>接口ID：6960166873968525315</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在数据表中删除一个字段</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="field_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>field id</para>
    /// <para>示例值：fldPTb0U2y</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/fields/{field_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto>> DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string field_id);

    /// <summary>
    /// <para>【多维表格】新增一个数据表</para>
    /// <para>接口ID：6960166873968541699</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过该接口，可以新增一个仅包含索引列的空数据表，也可以指定一部分初始字段。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesResponseDto>> PostBitableV1AppsByAppTokenTablesAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesBodyDto dto);

    /// <summary>
    /// <para>【多维表格】新增多个数据表</para>
    /// <para>接口ID：6960166873968558083</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/batch_create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>新增多个数据表。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/batch_create")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesBatchCreateResponseDto>> PostBitableV1AppsByAppTokenTablesBatchCreateAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesBatchCreateBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】获取多维表格元数据</para>
    /// <para>接口ID：6960166873968574467</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定多维表格的元数据信息，包括多维表格名称，多维表格版本号，多维表格是否开启高级权限等。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenResponseDto>> GetBitableV1AppsByAppTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token);

    /// <summary>
    /// <para>【视频会议】获取会议详情</para>
    /// <para>接口ID：6960861158128926723</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个会议的详细数据。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="with_participants">
    /// <para>必填：否</para>
    /// <para>是否需要参会人列表</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="with_meeting_ability">
    /// <para>必填：否</para>
    /// <para>是否需要会中使用能力统计（仅限tenant_access_token）</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/meetings/{meeting_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1MeetingsByMeetingIdResponseDto>> GetVcV1MeetingsByMeetingIdAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id,
        [PathQuery] bool? with_participants = null,
        [PathQuery] bool? with_meeting_ability = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】预约会议</para>
    /// <para>接口ID：6960861158129008643</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/reserve/apply</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建一个会议预约。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/vc/v1/reserves/apply")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PostVcV1ReservesApplyResponseDto>> PostVcV1ReservesApplyAsync(
        UserAccessToken access_token,
        [JsonContent] Vc.PostVcV1ReservesApplyBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】授权录制文件</para>
    /// <para>接口ID：6960861158129025027</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting-recording/set_permission</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>将一个会议的录制文件授权给组织、用户或公开到公网。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/vc/v1/meetings/{meeting_id}/recording/set_permission")]
    System.Threading.Tasks.Task<FeishuResponse> PatchVcV1MeetingsByMeetingIdRecordingSetPermissionAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id,
        [JsonContent] Vc.PatchVcV1MeetingsByMeetingIdRecordingSetPermissionBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】删除预约</para>
    /// <para>接口ID：6960861158129041411</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/reserve/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除一个预约。</para>
    /// </summary>
    /// <param name="reserve_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>预约ID（预约的唯一标识）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/vc/v1/reserves/{reserve_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteVcV1ReservesByReserveIdAsync(
        UserAccessToken access_token,
        [PathQuery] string reserve_id);

    /// <summary>
    /// <para>【视频会议】停止录制</para>
    /// <para>接口ID：6960861158129057795</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting-recording/stop</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>在会议中停止录制。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/vc/v1/meetings/{meeting_id}/recording/stop")]
    System.Threading.Tasks.Task<FeishuResponse> PatchVcV1MeetingsByMeetingIdRecordingStopAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id);

    /// <summary>
    /// <para>【视频会议】获取录制文件</para>
    /// <para>接口ID：6960861158593101828</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting-recording/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个会议的录制文件。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/meetings/{meeting_id}/recording")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1MeetingsByMeetingIdRecordingResponseDto>> GetVcV1MeetingsByMeetingIdRecordingAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id);

    /// <summary>
    /// <para>【视频会议】结束会议</para>
    /// <para>接口ID：6960861158593118212</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/end</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>结束一个进行中的会议。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/vc/v1/meetings/{meeting_id}/end")]
    System.Threading.Tasks.Task<FeishuResponse> PatchVcV1MeetingsByMeetingIdEndAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id);

    /// <summary>
    /// <para>【视频会议】邀请参会人</para>
    /// <para>接口ID：6960861158593134596</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/invite</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>邀请参会人进入会议。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/vc/v1/meetings/{meeting_id}/invite")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PatchVcV1MeetingsByMeetingIdInviteResponseDto>> PatchVcV1MeetingsByMeetingIdInviteAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id,
        [JsonContent] Vc.PatchVcV1MeetingsByMeetingIdInviteBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】开始录制</para>
    /// <para>接口ID：6960861158593150980</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting-recording/start</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>在会议中开始录制。</para>
    /// </summary>
    /// <param name="meeting_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
    /// <para>示例值：6911188411932033028</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/vc/v1/meetings/{meeting_id}/recording/start")]
    System.Threading.Tasks.Task<FeishuResponse> PatchVcV1MeetingsByMeetingIdRecordingStartAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_id,
        [JsonContent] Vc.PatchVcV1MeetingsByMeetingIdRecordingStartBodyDto dto);

    /// <summary>
    /// <para>【OKR】批量获取 OKR</para>
    /// <para>接口ID：6961663213280722945</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/okr/batch_get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 OKR id 批量获取 OKR。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>people_admin_id：以people_admin_id来识别用户</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="okr_ids">
    /// <para>必填：是</para>
    /// <para>OKR ID 列表，最多10个</para>
    /// <para>示例值：7043693679567028244</para>
    /// </param>
    /// <param name="lang">
    /// <para>必填：否</para>
    /// <para>请求OKR的语言版本（比如@的人名），lang=en_us/zh_cn，请求 Query中</para>
    /// <para>示例值：zh_cn</para>
    /// <para>默认值：zh_cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/okr/v1/okrs/batch_get")]
    System.Threading.Tasks.Task<FeishuResponse<Okr.GetOkrV1OkrsBatchGetResponseDto>> GetOkrV1OkrsBatchGetAsync(
        UserAccessToken access_token,
        [PathQuery] string[] okr_ids,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? lang = "zh_cn");

    /// <summary>
    /// <para>【OKR】获取用户的 OKR 列表</para>
    /// <para>接口ID：6961663213280739329</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/user-okr/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据用户的 id 获取 OKR 列表。</para>
    /// </summary>
    /// <param name="user_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>目标用户id</para>
    /// <para>示例值：ou-asdasdasdasdasd</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>people_admin_id：以people_admin_id来识别用户</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="offset">
    /// <para>必填：是</para>
    /// <para>请求列表的偏移（对应响应体的 okr_list 字段），offset&gt;=0</para>
    /// <para>示例值：0</para>
    /// </param>
    /// <param name="limit">
    /// <para>必填：是</para>
    /// <para>列表长度，0-10</para>
    /// <para>示例值：5</para>
    /// </param>
    /// <param name="lang">
    /// <para>必填：否</para>
    /// <para>请求OKR的语言版本（比如@的人名），lang=en_us/zh_cn</para>
    /// <para>示例值：zh_cn</para>
    /// <para>默认值：zh_cn</para>
    /// </param>
    /// <param name="period_ids">
    /// <para>必填：否</para>
    /// <para>period_id列表，最多10个</para>
    /// <para>示例值：["6951461264858777132"]</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/okr/v1/users/{user_id}/okrs")]
    System.Threading.Tasks.Task<FeishuResponse<Okr.GetOkrV1UsersByUserIdOkrsResponseDto>> GetOkrV1UsersByUserIdOkrsAsync(
        UserAccessToken access_token,
        [PathQuery] string user_id,
        [PathQuery] string offset,
        [PathQuery] string limit,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? lang = "zh_cn",
        [PathQuery] string[]? period_ids = null);

    /// <summary>
    /// <para>【日历】将 Exchange 账户绑定到飞书账户</para>
    /// <para>接口ID：6963176044560728066</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/exchange_binding/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口将 Exchange 账户绑定到飞书账户，进而支持 Exchange 日历的导入。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/exchange_bindings")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4ExchangeBindingsResponseDto>> PostCalendarV4ExchangeBindingsAsync(
        UserAccessToken access_token,
        [JsonContent] Calendar.PostCalendarV4ExchangeBindingsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】查询 Exchange 账户的绑定状态</para>
    /// <para>接口ID：6963176044560744450</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/exchange_binding/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口获取 Exchange 账户的绑定状态，包括 Exchange 日历的同步状态。</para>
    /// </summary>
    /// <param name="exchange_binding_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Exchange 绑定的唯一标识 ID。调用 [将 Exchange 账户绑定到飞书账户](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/exchange_binding/create) 绑定时，可从返回结果中获取 exchange_binding_id。</para>
    /// <para>示例值：ZW1haWxfYWRtaW5fZXhhbXBsZUBvdXRsb29rLmNvbSBlbWFpbF9hY2NvdW50X2V4YW1wbGVAb3V0bG9vay5jb20=</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/exchange_bindings/{exchange_binding_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4ExchangeBindingsByExchangeBindingIdResponseDto>> GetCalendarV4ExchangeBindingsByExchangeBindingIdAsync(
        UserAccessToken access_token,
        [PathQuery] string exchange_binding_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】解除 Exchange 账户绑定</para>
    /// <para>接口ID：6963176044560760834</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/exchange_binding/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口解除 Exchange 账户和飞书账户的绑定关系，Exchange 账户解除绑定后才能和其他飞书账户继续绑定。</para>
    /// </summary>
    /// <param name="exchange_binding_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Exchange 绑定的唯一标识 ID。调用 [将 Exchange 账户绑定到飞书账户](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/exchange_binding/create) 绑定时，可从返回结果中获取 exchange_binding_id。</para>
    /// <para>示例值：ZW1haWxfYWRtaW5fZXhhbXBsZUBvdXRsb29rLmNvbSBlbWFpbF9hY2NvdW50X2V4YW1wbGVAb3V0bG9vay5jb20=</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/calendar/v4/exchange_bindings/{exchange_binding_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteCalendarV4ExchangeBindingsByExchangeBindingIdAsync(
        UserAccessToken access_token,
        [PathQuery] string exchange_binding_id);

    /// <summary>
    /// <para>【云文档】获取筛选</para>
    /// <para>接口ID：6966945328390651906</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取子表的详细筛选信息</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>示例值：shtcnmBA\*****yGehy8</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>示例值：0b\**12</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id);

    /// <summary>
    /// <para>【云文档】创建筛选</para>
    /// <para>接口ID：6966945328390668290</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在子表内创建筛选。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA\*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b\**12"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter")]
    System.Threading.Tasks.Task<FeishuResponse> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新筛选</para>
    /// <para>接口ID：6966945328390684674</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新子表筛选范围中的列筛选条件。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA\*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b\**12"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter")]
    System.Threading.Tasks.Task<FeishuResponse> PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.Spec.PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterBodyDto dto);

    /// <summary>
    /// <para>【云文档】删除筛选</para>
    /// <para>接口ID：6966945328390701058</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除子表的筛选</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA\*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b\**12"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id);

    /// <summary>
    /// <para>【云文档】移动行列</para>
    /// <para>接口ID：6969403095454416924</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/move_dimension</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于移动行或列。行或列被移动到目标位置后，原本在目标位置的行列会对应右移或下移。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID</para>
    /// <para>示例值：2jm6f6</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/move_dimension")]
    System.Threading.Tasks.Task<FeishuResponse> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdMoveDimensionAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdMoveDimensionBodyDto dto);

    /// <summary>
    /// <para>【云文档】创建电子表格</para>
    /// <para>接口ID：6969763153149476865</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在云空间指定目录下创建电子表格。可自定义表格标题。不支持带内容创建表格。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostSheetsV3SpreadsheetsResponseDto>> PostSheetsV3SpreadsheetsAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostSheetsV3SpreadsheetsBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新筛选条件</para>
    /// <para>接口ID：6970504825797541891</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新筛选视图范围的某列的筛选条件，condition id 即为列的字母号。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="condition_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>列字母号</para>
    /// <para>**示例值**："E"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}/conditions/{condition_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdResponseDto>> PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id,
        [PathQuery] string condition_id,
        [JsonContent] Ccm.Spec.PutSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取筛选视图</para>
    /// <para>接口ID：6970504825797558275</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定筛选视图 id 的名字和筛选范围。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id);

    /// <summary>
    /// <para>【云文档】查询筛选视图</para>
    /// <para>接口ID：6970504825797574659</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询子表内所有的筛选视图基本信息，包括 id、name 和 range</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/query")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsQueryAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id);

    /// <summary>
    /// <para>【云文档】更新筛选视图</para>
    /// <para>接口ID：6970504825797591043</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新筛选视图的名字或者筛选范围。名字长度不超过100，不能重复即子表内唯一；筛选范围不超过子表的最大范围。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdResponseDto>> PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id,
        [JsonContent] Ccm.Spec.PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】查询筛选条件</para>
    /// <para>接口ID：6970504825797607427</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询一个筛选视图的所有筛选条件，返回筛选视图的筛选范围内的筛选条件。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}/conditions/query")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsQueryResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsQueryAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id);

    /// <summary>
    /// <para>【云文档】获取筛选条件</para>
    /// <para>接口ID：6970504825797623811</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取筛选视图某列的筛选条件信息。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="condition_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要查询筛选条件的列字母号</para>
    /// <para>**示例值**："E"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}/conditions/{condition_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id,
        [PathQuery] string condition_id);

    /// <summary>
    /// <para>【云文档】删除筛选条件</para>
    /// <para>接口ID：6970504825797640195</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除筛选视图的筛选范围某一列的筛选条件。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="condition_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选范围内的某列字母号</para>
    /// <para>**示例值**："E"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}/conditions/{condition_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsByConditionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id,
        [PathQuery] string condition_id);

    /// <summary>
    /// <para>【云文档】创建筛选视图</para>
    /// <para>接口ID：6970504825797672963</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据传入的参数创建一个筛选视图。Id 和 名字可选，不填的话会默认生成；range 必填。Id 长度为10，由 0-9、a-z、A-Z 组合生成。名字长度不超过100。单个子表内的筛选视图个数不超过 150。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsResponseDto>> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsBodyDto dto);

    /// <summary>
    /// <para>【云文档】删除筛选视图</para>
    /// <para>接口ID：6970504825797689347</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除指定 id 对应的筛选视图。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id);

    /// <summary>
    /// <para>【云文档】创建筛选条件</para>
    /// <para>接口ID：6970504825797705731</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-filter_view-condition/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在筛选视图的筛选范围的某一列创建筛选条件。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="filter_view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>筛选视图 id</para>
    /// <para>**示例值**："pH9hbVcCXA"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/filter_views/{filter_view_id}/conditions")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsResponseDto>> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string filter_view_id,
        [JsonContent] Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFilterViewsByFilterViewIdConditionsBodyDto dto);

    /// <summary>
    /// <para>【服务台】更新客服信息</para>
    /// <para>接口ID：6974742353936842753</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/agent/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>更新客服状态等信息。</para>
    /// </summary>
    /// <param name="agent_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>客服id</para>
    /// <para>示例值：ou_14777d82ffef0f707de5a8c7ff2c5ebe</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/agents/{agent_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1AgentsByAgentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string agent_id,
        [JsonContent] Helpdesk.PatchHelpdeskV1AgentsByAgentIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】创建浮动图片</para>
    /// <para>接口ID：6976178542817230851</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据传入的参数创建一张浮动图片。Float_image_token （[上传图片至表格后得到](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)）和range（只支持一个单元格） 必填。Float_image_id 可选，不填的话会默认生成，长度为10，由 0-9、a-z、A-Z 组合生成。表格内不重复的图片（浮动图片+单元格图片）总数不超过4000。width 和 height 为图片展示的宽高，可选，不填的话会使用图片的真实宽高。offset_x 和 offset_y 为图片左上角距离所在单元格左上角的偏移，可选，默认为 0。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/float_images")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesResponseDto>> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.Spec.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取浮动图片</para>
    /// <para>接口ID：6976178542817247235</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 float_image_id 获取对应浮动图片的信息。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="float_image_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>浮动图片 id</para>
    /// <para>**示例值**："ye06SS14ph"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/float_images/{float_image_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string float_image_id);

    /// <summary>
    /// <para>【云文档】查询浮动图片</para>
    /// <para>接口ID：6976178542817263619</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>返回子表内所有的浮动图片信息。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/float_images/query")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesQueryResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesQueryAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id);

    /// <summary>
    /// <para>【云文档】更新浮动图片</para>
    /// <para>接口ID：6976178542817280003</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新已有的浮动图片位置和宽高，包括 range、width、height、offset_x 和 offset_y，不包括 float_image_id 和 float_image_token。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="float_image_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>浮动图片 id</para>
    /// <para>**示例值**："ye06SS14ph"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/float_images/{float_image_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto>> PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string float_image_id,
        [JsonContent] Ccm.Spec.PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】删除浮动图片</para>
    /// <para>接口ID：6976178542817296387</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除 float_image_id 对应的浮动图片。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 token</para>
    /// <para>**示例值**："shtcnmBA*****yGehy8"</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>子表 id</para>
    /// <para>**示例值**："0b**12"</para>
    /// </param>
    /// <param name="float_image_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>浮动图片 id</para>
    /// <para>**示例值**："ye06SS14ph"</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/float_images/{float_image_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [PathQuery] string float_image_id);

    /// <summary>
    /// <para>【多维表格】列出视图</para>
    /// <para>接口ID：6978670625209597954</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-view/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 app_token 和 table_id，获取数据表的所有视图</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：vewTpR1urY</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/views")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdViewsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】新增视图</para>
    /// <para>接口ID：6978670625209614338</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-view/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在数据表中新增一个视图</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/views")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdViewsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdViewsBodyDto dto);

    /// <summary>
    /// <para>【多维表格】删除视图</para>
    /// <para>接口ID：6978670625209630722</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-view/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除数据表中的视图</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>视图Id</para>
    /// <para>示例值：vewTpR1urY</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/views/{view_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string view_id);

    /// <summary>
    /// <para>【云文档】删除Sheet</para>
    /// <para>接口ID：6979502797244153859</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUTNzUjL1UzM14SN1MTN/delete-sheet</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete)</para>
    /// <para>该接口用于根据 spreadsheetToken 删除对应的 sheet 文档。</para>
    /// <para>文档只能被文档所有者删除，文档被删除后将会放到回收站里</para>
    /// <para>该接口不支持并发调用，且调用频率上限为5QPS</para>
    /// </summary>
    /// <param name="spreadsheetToken">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>spreadsheet 的 token，获取方式见 [概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/files/guide/introduction)</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [Obsolete("迁移至新版本：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete")]
    [HttpDelete("/open-apis/drive/explorer/v2/file/spreadsheets/{spreadsheetToken}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.DeleteDriveExplorerV2FileSpreadsheetsBySpreadsheetTokenResponseDto>> DeleteDriveExplorerV2FileSpreadsheetsBySpreadsheetTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheetToken);

    /// <summary>
    /// <para>【云文档】获取我的空间（root folder）元数据</para>
    /// <para>接口ID：6979502797244170243</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/get-root-folder-meta</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取用户“我的空间”（root folder）的元数据，包括文件夹的 token、ID 和文件夹所有者的 ID。</para>
    /// </summary>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/explorer/v2/root_folder/meta")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.Spec.GetDriveExplorerV2RootFolderMetaResponseDto>> GetDriveExplorerV2RootFolderMetaAsync(
        UserAccessToken access_token);

    /// <summary>
    /// <para>【云文档】分片上传文件-完成上传</para>
    /// <para>接口ID：6979562676003766300</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_finish</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用[上传分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_part)接口将分片全部上传完毕后，你需调用本接口触发完成上传。否则将上传失败。了解完整的上传文件流程，参考[上传文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/multipart-upload-file-/introduction)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/upload_finish")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesUploadFinishResponseDto>> PostDriveV1FilesUploadFinishAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1FilesUploadFinishBodyDto dto);

    /// <summary>
    /// <para>【云文档】分片上传文件-预上传</para>
    /// <para>接口ID：6979562676003815452</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_prepare</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>发送初始化请求，以获取上传事务 ID 和分片策略，为[上传分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_part)做准备。平台固定以 4MB 的大小对文件进行分片。了解完整的上传文件流程，参考[上传文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/multipart-upload-file-/introduction)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/upload_prepare")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesUploadPrepareResponseDto>> PostDriveV1FilesUploadPrepareAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1FilesUploadPrepareBodyDto dto);

    /// <summary>
    /// <para>【云文档】上传素材</para>
    /// <para>接口ID：6979562676003831836</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将文件、图片、视频等素材上传到指定云文档中。素材将显示在对应云文档中，在云空间中不会显示。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>文件的二进制内容</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/medias/upload_all")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1MediasUploadAllResponseDto>> PostDriveV1MediasUploadAllAsync(
        UserAccessToken access_token,
        [FormDataContent] Ccm.PostDriveV1MediasUploadAllBodyDto dto,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【云文档】分片上传素材-预上传</para>
    /// <para>接口ID：6979562676003848220</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>发送初始化请求，以获取上传事务 ID 和分片策略，为[上传素材分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_part)做准备。平台固定以 4MB 的大小对素材进行分片。了解完整的分片上传素材流程，参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/medias/upload_prepare")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1MediasUploadPrepareResponseDto>> PostDriveV1MediasUploadPrepareAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1MediasUploadPrepareBodyDto dto);

    /// <summary>
    /// <para>【云文档】上传文件</para>
    /// <para>接口ID：6979562676003864604</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_all</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将指定文件上传至云空间指定目录中。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>文件的二进制内容</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/upload_all")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesUploadAllResponseDto>> PostDriveV1FilesUploadAllAsync(
        UserAccessToken access_token,
        [FormDataContent] Ccm.PostDriveV1FilesUploadAllBodyDto dto,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【云文档】分片上传素材-完成上传</para>
    /// <para>接口ID：6979562676003880988</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_finish</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用[上传分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_part)接口将分片全部上传完毕后，你需调用本接口触发完成上传。了解完整的分片上传素材流程，参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/medias/upload_finish")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1MediasUploadFinishResponseDto>> PostDriveV1MediasUploadFinishAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1MediasUploadFinishBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取素材临时下载链接</para>
    /// <para>接口ID：6979562676003897372</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/batch_get_tmp_download_url</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取云文档中素材的临时下载链接。链接的有效期为 24 小时，过期失效。</para>
    /// </summary>
    /// <param name="file_tokens">
    /// <para>必填：是</para>
    /// <para>素材文件的 token。获取方式如下所示：</para>
    /// <para>* 新版文档：通过[获取文档所有块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/list)接口获取指定文件块（File Block）或图片块（Image Block）的 token，即为素材 token。</para>
    /// <para>* 电子表格：通过[读取多个范围](https://open.feishu.cn/document/ukTMukTMukTM/ukTMzUjL5EzM14SOxMTN)接口获取指定附件的</para>
    /// <para>`fileToken`，即为素材的 token。</para>
    /// <para>* 多维表格：通过[列出记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/list)接口获取指定附件的 `file_token`，即为素材的 token。</para>
    /// <para>如需一次获取多个素材的下载链接，可多次传递本参数及素材的 token 值，格式如下：</para>
    /// <para>`https://{url}?file_tokens={token1}&amp;file_tokens={token2}`</para>
    /// <para>其中：</para>
    /// <para>- `file_tokens` 是参数名，可以多次传递</para>
    /// <para>- `token1` 和 `token2` 为素材的实际 token 值</para>
    /// <para>- 你最多可一次获取五个素材的下载链接</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </param>
    /// <param name="extra">
    /// <para>必填：否</para>
    /// <para>拓展信息，如拥有高级权限的多维表格在下载素材时，需要添加额外的扩展信息作为 URL 查询参数鉴权。详情参考[extra 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。未填正确填写该参数的接口将返回 403 的 HTTP 状态码。</para>
    /// <para>示例值：请参考 [extra 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/medias/batch_get_tmp_download_url")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1MediasBatchGetTmpDownloadUrlResponseDto>> GetDriveV1MediasBatchGetTmpDownloadUrlAsync(
        UserAccessToken access_token,
        [PathQuery] string[] file_tokens,
        [PathQuery] string? extra = null);

    /// <summary>
    /// <para>【云文档】下载素材</para>
    /// <para>接口ID：6979562676003913756</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/download</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>下载各类云文档中的素材，例如电子表格中的图片。该接口支持通过在请求头添加`Range` 参数分片下载素材。</para>
    /// </summary>
    /// <param name="range">
    /// <para>通过指定 HTTP 请求头的Range来下载素材的部分内容，单位是byte，即字节。</para>
    /// <para>Range格式为Range: bytes=start-end，例如Range: bytes=0-1024，表示下载第 0 个字节到第 1024 个字节之间的数据。</para>
    /// </param>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>素材文件的 token。获取方式如下所示：</para>
    /// <para>* 新版文档：通过[获取文档所有块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/list)接口获取指定文件块（File Block）或图片块（Image Block）的 token，即为素材的 token。</para>
    /// <para>* 电子表格：通过[读取多个范围](https://open.feishu.cn/document/ukTMukTMukTM/ukTMzUjL5EzM14SOxMTN)接口获取指定附件的</para>
    /// <para>`fileToken` 参数，即为素材的 token。</para>
    /// <para>* 多维表格：通过[列出记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/list)接口获取指定附件的 `file_token`，即为素材的 token。</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </param>
    /// <param name="extra">
    /// <para>必填：否</para>
    /// <para>拥有高级权限的多维表格在下载素材时，需要添加额外的扩展信息作为 URL 查询参数鉴权。详情参考[素材概述-extra 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。未填正确填写该参数的接口将返回 403 的 HTTP 状态码。</para>
    /// <para>示例值：无</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <returns>返回文件二进制流</returns>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/medias/{file_token}/download")]
    System.Threading.Tasks.Task<HttpResponseMessage> GetDriveV1MediasByFileTokenDownloadAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [Header][AliasAs("Range")] string? range = null,
        [PathQuery] string? extra = null);

    /// <summary>
    /// <para>【云文档】分片上传文件-上传分片</para>
    /// <para>接口ID：6979562676003930140</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_part</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 [预上传](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_prepare)接口返回的上传事务 ID 和分片策略上传对应的文件分片。上传完成后，你需调用[分片上传文件（完成上传）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_finish)触发完成上传。了解完整的上传文件流程，参考[分片上传文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/multipart-upload-file-/introduction)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>文件分片的二进制内容</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/upload_part")]
    System.Threading.Tasks.Task<FeishuResponse> PostDriveV1FilesUploadPartAsync(
        UserAccessToken access_token,
        [FormDataContent] Ccm.PostDriveV1FilesUploadPartBodyDto dto,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【云文档】下载文件</para>
    /// <para>接口ID：6979562676003946524</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/download</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>下载云空间中的文件，如 PDF 文件。不包含飞书文档、电子表格以及多维表格等在线文档。该接口支持通过在请求头添加 `Range` 参数分片下载部分文件。</para>
    /// </summary>
    /// <param name="range">
    /// <para>通过指定 HTTP 请求头的Range来下载素材的部分内容，单位是byte，即字节。</para>
    /// <para>Range格式为Range: bytes=start-end，例如Range: bytes=0-1024，表示下载第 0 个字节到第 1024 个字节之间的数据。</para>
    /// </param>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)。</para>
    /// <para>示例值：boxcnabCdefgabcef</para>
    /// </param>
    /// <returns>返回文件二进制流</returns>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/download")]
    System.Threading.Tasks.Task<HttpResponseMessage> GetDriveV1FilesByFileTokenDownloadAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [Header][AliasAs("Range")] string? range = null);

    /// <summary>
    /// <para>【云文档】分片上传素材-上传分片</para>
    /// <para>接口ID：6979562676003979292</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_part</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 [预上传](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare)接口返回的上传事务 ID 和分片策略上传对应的素材分片。上传完成后，你可调用 [分片上传素材（完成上传）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_finish)触发完成上传。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>素材文件分片的二进制内容</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/medias/upload_part")]
    System.Threading.Tasks.Task<FeishuResponse> PostDriveV1MediasUploadPartAsync(
        UserAccessToken access_token,
        [FormDataContent] Ccm.PostDriveV1MediasUploadPartBodyDto dto,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【云文档】查找单元格</para>
    /// <para>接口ID：6982374372208590850</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/find</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在指定范围内查找符合查找条件的单元格。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工作表的 ID，获取方式见[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)。</para>
    /// <para>示例值：PNIfrm</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/find")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindResponseDto>> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFindBodyDto dto);

    /// <summary>
    /// <para>【云文档】替换单元格</para>
    /// <para>接口ID：6982374372208607234</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/replace</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在指定范围内，查找并替换符合查找条件的单元格。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工作表的 ID，获取方式见[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)。</para>
    /// <para>示例值：PNIfrm</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}/replace")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceResponseDto>> PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id,
        [JsonContent] Ccm.PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdReplaceBodyDto dto);

    /// <summary>
    /// <para>【任务】获取关注人列表</para>
    /// <para>接口ID：6985127383322165250</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-follower/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于查询任务关注人列表，支持分页，最大值为50。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>**示例值**："0d38e26e-190a-49e9-93a2-35067763ed1f"</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>**示例值**：10</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最大值：`50`</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>**示例值**："「上次返回的page_token」"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>**示例值**："open_id"</para>
    /// <para>**可选值有**：</para>
    /// <para>open_id:标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid),union_id:标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id),user_id:标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</para>
    /// <para>**默认值**：`open_id`</para>
    /// <para>**当值为 `user_id`，字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee_id:readonly" desc="获取用户 user ID" support_app_types="custom" tags=""&gt;获取用户 user ID&lt;/md-perm&gt;</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](/ssl</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](/ssl</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](/ssl</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks/{task_id}/followers")]
    System.Threading.Tasks.Task<FeishuResponse<Task.Spec.GetTaskV1TasksByTaskIdFollowersResponseDto>> GetTaskV1TasksByTaskIdFollowersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】新增关注人</para>
    /// <para>接口ID：6985127383322181634</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-follower/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于新增任务关注人。可以一次性添加多位关注人。关注人ID要使用表示用户的ID。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/followers")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksByTaskIdFollowersResponseDto>> PostTaskV1TasksByTaskIdFollowersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PostTaskV1TasksByTaskIdFollowersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】新增执行者</para>
    /// <para>接口ID：6985127383322198018</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-collaborator/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于新增任务执行者，一次性可以添加多个执行者。</para>
    /// <para>只有任务的创建者和执行者才能添加执行者，关注人无权限添加。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID，可通过[创建任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/create)时响应体中的id字段获取</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/collaborators")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksByTaskIdCollaboratorsResponseDto>> PostTaskV1TasksByTaskIdCollaboratorsAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PostTaskV1TasksByTaskIdCollaboratorsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除提醒时间</para>
    /// <para>接口ID：6985127383322214402</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-reminder/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除提醒时间，返回结果状态。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="reminder_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务提醒时间设置的 ID（即 reminder.id）</para>
    /// <para>示例值：1</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v1/tasks/{task_id}/reminders/{reminder_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV1TasksByTaskIdRemindersByReminderIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string reminder_id);

    /// <summary>
    /// <para>【任务】获取执行者列表</para>
    /// <para>接口ID：6985127383322230786</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-collaborator/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于查询任务执行者列表，支持分页，最大值为50。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：0d38e26e-190a-49e9-93a2-35067763ed1f</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：「上次返回的page_token」</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks/{task_id}/collaborators")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV1TasksByTaskIdCollaboratorsResponseDto>> GetTaskV1TasksByTaskIdCollaboratorsAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】取消完成任务</para>
    /// <para>接口ID：6985127383322247170</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/uncomplete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于取消任务的已完成状态。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：bb54ab99-d360-434f-bcaa-a4cc4c05840e</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/uncomplete")]
    System.Threading.Tasks.Task<FeishuResponse> PostTaskV1TasksByTaskIdUncompleteAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id);

    /// <summary>
    /// <para>【任务】查询指定任务</para>
    /// <para>接口ID：6985127383322263554</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取任务详情，包括任务标题、描述、时间、来源等信息。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks/{task_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV1TasksByTaskIdResponseDto>> GetTaskV1TasksByTaskIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除任务</para>
    /// <para>接口ID：6985127383322279938</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除任务。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v1/tasks/{task_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV1TasksByTaskIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id);

    /// <summary>
    /// <para>【任务】创建任务</para>
    /// <para>接口ID：6985127383322296322</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口可以创建一个任务，支持填写任务的基本信息，包括任务的标题，描述及协作者等。</para>
    /// <para>在此基础上，创建任务时可以设置截止时间和重复规则，将任务设置为定期执行的重复任务。通过添加协作者，则可以让其他用户协同完成该任务。</para>
    /// <para>此外，接口也提供了一些支持自定义内容的字段，调用方可以实现定制化效果，如完成任务后跳转到指定结束界面。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksResponseDto>> PostTaskV1TasksAsync(
        UserAccessToken access_token,
        [JsonContent] Task.PostTaskV1TasksBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】新增提醒时间</para>
    /// <para>接口ID：6985127383322312706</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-reminder/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于创建任务的提醒时间。提醒时间在截止时间基础上做偏移，但是偏移后的结果不能早于当前时间。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/reminders")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksByTaskIdRemindersResponseDto>> PostTaskV1TasksByTaskIdRemindersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PostTaskV1TasksByTaskIdRemindersBodyDto dto);

    /// <summary>
    /// <para>【任务】完成任务</para>
    /// <para>接口ID：6985127383322329090</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/complete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于将任务状态修改为“已完成”。</para>
    /// <para>完成任务是指整个任务全部完成，而不支持执行者分别完成任务，执行成功后，任务对所有关联用户都变为完成状态。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID，可通过[创建任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/create)时响应体中的id字段获取</para>
    /// <para>示例值：bb54ab99-d360-434f-bcaa-a4cc4c05840e</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/complete")]
    System.Threading.Tasks.Task<FeishuResponse> PostTaskV1TasksByTaskIdCompleteAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id);

    /// <summary>
    /// <para>【任务】删除指定关注人</para>
    /// <para>接口ID：6985127383322345474</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-follower/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除任务关注人。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="follower_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务关注人 ID（Open ID或User ID，由user_id_type指定）</para>
    /// <para>示例值：ou_87e1a581b36ecc4862cbfbce473f346a</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v1/tasks/{task_id}/followers/{follower_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV1TasksByTaskIdFollowersByFollowerIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string follower_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除指定执行者</para>
    /// <para>接口ID：6985127383322361858</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-collaborator/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于删除任务执行者。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="collaborator_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务执行者 ID（Open ID或User ID，由user_id_type指定）</para>
    /// <para>示例值：ou_99e1a581b36ecc4862cbfbce123f346a</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v1/tasks/{task_id}/collaborators/{collaborator_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV1TasksByTaskIdCollaboratorsByCollaboratorIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string collaborator_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新任务</para>
    /// <para>接口ID：6985127383322378242</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于修改任务的标题、描述、时间、来源等相关信息。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v1/tasks/{task_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV1TasksByTaskIdResponseDto>> PatchTaskV1TasksByTaskIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PatchTaskV1TasksByTaskIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】查询提醒时间列表</para>
    /// <para>接口ID：6985127383322394626</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-reminder/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>返回提醒时间列表，支持分页，最大值为50。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：0d38e26e-190a-49e9-93a2-35067763ed1f</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：「填写上次返回的page_token」</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks/{task_id}/reminders")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV1TasksByTaskIdRemindersResponseDto>> GetTaskV1TasksByTaskIdRemindersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【审批】查询用户的任务列表</para>
    /// <para>接口ID：6986936689592549378</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据用户和任务分组查询任务列表。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>**示例值**：100</para>
    /// <para>**默认值**：`100`</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 最大值：`200`</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>**示例值**："1"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id">
    /// <para>必填：是</para>
    /// <para>需要查询的 User ID</para>
    /// <para>**示例值**："example_user_id"</para>
    /// </param>
    /// <param name="topic">
    /// <para>必填：是</para>
    /// <para>需要查询的任务分组主题，如「待办」、「已办」等</para>
    /// <para>**示例值**："1"</para>
    /// <para>**可选值有**：</para>
    /// <para>1:待办审批,2:已办审批,3:已发起审批,17:未读知会,18:已读知会</para>
    /// <list type="bullet">
    /// <item>1：待办审批</item>
    /// <item>2：已办审批</item>
    /// <item>3：已发起审批</item>
    /// <item>17：未读知会</item>
    /// <item>18：已读知会</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>**示例值**："open_id"</para>
    /// <para>**可选值有**：</para>
    /// <para>open_id:标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid),union_id:标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id),user_id:标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</para>
    /// <para>**默认值**：`open_id`</para>
    /// <para>**当值为 `user_id`，字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee_id:readonly" desc="获取用户 user ID" support_app_types="custom" tags=""&gt;获取用户 user ID&lt;/md-perm&gt;</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](/ssl</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](/ssl</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](/ssl</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/approval/v4/tasks/query")]
    System.Threading.Tasks.Task<FeishuResponse<Approval.Spec.GetApprovalV4TasksQueryResponseDto>> GetApprovalV4TasksQueryAsync(
        UserAccessToken access_token,
        [PathQuery] string user_id,
        [PathQuery] string topic,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】增加协作者权限</para>
    /// <para>接口ID：6987581166854635521</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件的 token 给用户增加文档的权限。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>folder：文件夹</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="need_notification">
    /// <para>必填：否</para>
    /// <para>添加权限后是否通知对方</para>
    /// <para>**注意：** 使用`tenant_access_token`访问不支持该参数</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/permissions/{token}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1PermissionsByTokenMembersResponseDto>> PostDriveV1PermissionsByTokenMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type,
        [JsonContent] Ccm.PostDriveV1PermissionsByTokenMembersBodyDto dto,
        [PathQuery] bool? need_notification = false);

    /// <summary>
    /// <para>【云文档】更新云文档权限设置</para>
    /// <para>接口ID：6987581166854651905</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-public/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 更新云文档的权限设置。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/drive/v1/permissions/{token}/public")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PatchDriveV1PermissionsByTokenPublicResponseDto>> PatchDriveV1PermissionsByTokenPublicAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type,
        [JsonContent] Ccm.PatchDriveV1PermissionsByTokenPublicBodyDto dto);

    /// <summary>
    /// <para>【云文档】查询导入任务结果</para>
    /// <para>接口ID：6987581325629931521</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据[创建导入任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/create)返回的导入任务 ID（ticket）轮询导入结果。了解完整的导入文件步骤，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
    /// </summary>
    /// <param name="ticket">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>导入任务 ID。调用[创建导入任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/create) 获取</para>
    /// <para>示例值：7369583175086912356</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/import_tasks/{ticket}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1ImportTasksByTicketResponseDto>> GetDriveV1ImportTasksByTicketAsync(
        UserAccessToken access_token,
        [PathQuery] string ticket);

    /// <summary>
    /// <para>【云文档】创建导入任务</para>
    /// <para>接口ID：6987581325629947905</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于创建导入文件的任务，并返回导入任务 ID。导入文件指将本地文件如 Word、TXT、Markdown、Excel 等格式的文件导入为某种格式的飞书在线云文档。该接口为异步接口，需要继续调用[查询导入任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/get)接口获取导入结果。了解完整的导入文件步骤，参考[导入文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/import_tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1ImportTasksResponseDto>> PostDriveV1ImportTasksAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1ImportTasksBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取文件统计信息</para>
    /// <para>接口ID：6989584844481544196</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-statistics/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于获取各类文件的流量统计信息和互动信息，包括阅读人数、阅读次数和点赞数。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件 token。了解如何获取文件 token，参考[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)。</para>
    /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文件类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>bitable：多维表格</item>
    /// <item>wiki：知识库文档</item>
    /// <item>file：文件</item>
    /// <item>docx：新版文档</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/statistics")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenStatisticsResponseDto>> GetDriveV1FilesByFileTokenStatisticsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type);

    /// <summary>
    /// <para>【日历】创建日程</para>
    /// <para>接口ID：6990540948577599491</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）在指定日历上创建一个日程。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="idempotency_key">
    /// <para>必填：否</para>
    /// <para>创建日程的幂等 key，该 key 在应用和日历维度下唯一，用于避免重复创建资源。建议按照示例值的格式进行取值。</para>
    /// <para>示例值：25fdf41b-8c80-2ce1-e94c-de8b5e7aa7e6</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsByCalendarIdEventsResponseDto>> PostCalendarV4CalendarsByCalendarIdEventsAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [JsonContent] Calendar.PostCalendarV4CalendarsByCalendarIdEventsBodyDto dto,
        [PathQuery] string? idempotency_key = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】获取消息表情回复</para>
    /// <para>接口ID：6990603997012279298</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定消息的特定类型表情回复列表（reaction即表情回复，本文档统一用“reaction”代称）。</para>
    /// </summary>
    /// <param name="message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待获取reaction的消息ID，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>示例值：om_8964d1b4*********2b31383276113</para>
    /// </param>
    /// <param name="reaction_type">
    /// <para>必填：否</para>
    /// <para>待查询消息reaction的类型[emoji类型列举](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/emojis-introduce)</para>
    /// <para>**注意**：不传入该参数，表示拉取所有类型reaction</para>
    /// <para>示例值：LAUGH</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：YhljsPiGfUgnVAg9urvRFd-BvSqRL20wMZNAWfa9xXkud6UKCybPuUgQ1vM26dj6</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/messages/{message_id}/reactions")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1MessagesByMessageIdReactionsResponseDto>> GetImV1MessagesByMessageIdReactionsAsync(
        UserAccessToken access_token,
        [PathQuery] string message_id,
        [PathQuery] string? reaction_type = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】删除消息表情回复</para>
    /// <para>接口ID：6990603997012295682</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除指定消息的表情回复（reaction即表情回复，本文档统一用“reaction”代称）。</para>
    /// </summary>
    /// <param name="message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待删除reaction的消息ID，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>示例值：om_8964d1b4*********2b31383276113</para>
    /// </param>
    /// <param name="reaction_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待删除reaction的资源id，可通过调用[添加消息表情回复](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/create)接口或[获取消息表情回复](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/list)获得</para>
    /// <para>示例值：ZCaCIjUBVVWSrm5L-3ZTw*************sNa8dHVplEzzSfJVUVLMLcS_</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/im/v1/messages/{message_id}/reactions/{reaction_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Im.DeleteImV1MessagesByMessageIdReactionsByReactionIdResponseDto>> DeleteImV1MessagesByMessageIdReactionsByReactionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string message_id,
        [PathQuery] string reaction_id);

    /// <summary>
    /// <para>【消息与群组】添加消息表情回复</para>
    /// <para>接口ID：6990603997012312066</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给指定消息添加指定类型的表情回复（reaction即表情回复，本文档统一用“reaction”代称）。</para>
    /// </summary>
    /// <param name="message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待添加reaction的消息ID，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>示例值：om_a8f2294b************a1a38afaac9d</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/messages/{message_id}/reactions")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1MessagesByMessageIdReactionsResponseDto>> PostImV1MessagesByMessageIdReactionsAsync(
        UserAccessToken access_token,
        [PathQuery] string message_id,
        [JsonContent] Im.PostImV1MessagesByMessageIdReactionsBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】指定群管理员</para>
    /// <para>接口ID：6995085510524698625</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-managers/add_managers</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将用户或机器人指定为群管理员。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：仅支持群模式为`group`、`topic`的群组ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>app_id：飞书开放平台应用的唯一标识。在创建应用时，由系统自动生成，用户不能自行修改。[了解更多：如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/managers/add_managers")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdManagersAddManagersResponseDto>> PostImV1ChatsByChatIdManagersAddManagersAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdManagersAddManagersBodyDto dto,
        [PathQuery] string? member_id_type = "open_id");

    /// <summary>
    /// <para>【消息与群组】删除群管理员</para>
    /// <para>接口ID：6995085510524715009</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-managers/delete_managers</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除指定的群管理员（用户或机器人）。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：仅支持群模式为`group`、`topic`的群组ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>app_id：飞书开放平台应用的唯一标识。在创建应用时，由系统自动生成，用户不能自行修改。[了解更多：如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/managers/delete_managers")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdManagersDeleteManagersResponseDto>> PostImV1ChatsByChatIdManagersDeleteManagersAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdManagersDeleteManagersBodyDto dto,
        [PathQuery] string? member_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】移除协作者权限</para>
    /// <para>接口ID：6998069547745214492</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件的 token 移除文档协作者的权限。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="member_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>协作者 ID，与协作者 ID 类型需要对应</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>folder：文件夹</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="member_type">
    /// <para>必填：是</para>
    /// <para>协作者 ID 类型，与协作者 ID 需要对应</para>
    /// <para>示例值：openid</para>
    /// <list type="bullet">
    /// <item>email：邮箱地址</item>
    /// <item>openid：开放平台 ID</item>
    /// <item>openchat：开放平台群组 ID</item>
    /// <item>opendepartmentid：开放平台部门 ID</item>
    /// <item>userid：用户自定义 ID</item>
    /// <item>unionid：开放平台 UnionID</item>
    /// <item>groupid：自定义用户组 ID</item>
    /// <item>wikispaceid：知识空间 ID - **注意**：仅知识库文档支持该参数，当需要操作知识库文档里的「知识库成员」类型协作者时传该参数</item>
    /// </list>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/drive/v1/permissions/{token}/members/{member_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteDriveV1PermissionsByTokenMembersByMemberIdAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string member_id,
        [PathQuery] string type,
        [PathQuery] string member_type,
        [JsonContent] Ccm.DeleteDriveV1PermissionsByTokenMembersByMemberIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新协作者权限</para>
    /// <para>接口ID：6998069547745230876</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件的 token 更新文档协作者的权限。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="member_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>协作者 ID，与协作者 ID 类型需要对应</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </param>
    /// <param name="need_notification">
    /// <para>必填：否</para>
    /// <para>更新权限后是否通知对方</para>
    /// <para>**注意：** 使用`tenant_access_token`访问不支持该参数</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/drive/v1/permissions/{token}/members/{member_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PutDriveV1PermissionsByTokenMembersByMemberIdResponseDto>> PutDriveV1PermissionsByTokenMembersByMemberIdAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string member_id,
        [PathQuery] string type,
        [JsonContent] Ccm.PutDriveV1PermissionsByTokenMembersByMemberIdBodyDto dto,
        [PathQuery] bool? need_notification = false);

    /// <summary>
    /// <para>【服务台】预览推送</para>
    /// <para>接口ID：6999529163292491778</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/preview</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>在正式执行推送之前是可以调用此接口预览设置的推送内容。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>创建推送接口成功后返回的唯一id</para>
    /// <para>示例值：6985032626234982420</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/notifications/{notification_id}/preview")]
    System.Threading.Tasks.Task<FeishuResponse> PostHelpdeskV1NotificationsByNotificationIdPreviewAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id);

    /// <summary>
    /// <para>【服务台】提交审核</para>
    /// <para>接口ID：6999529163292508162</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/submit_approve</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>正常情况下调用创建推送接口后，就可以调用提交审核接口，如果创建人是服务台owner则会自动审核通过，否则会通知服务台owner审核此推送信息。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>创建接口返回的唯一id</para>
    /// <para>示例值：6985032626234982420</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/notifications/{notification_id}/submit_approve")]
    System.Threading.Tasks.Task<FeishuResponse<Helpdesk.PostHelpdeskV1NotificationsByNotificationIdSubmitApproveResponseDto>> PostHelpdeskV1NotificationsByNotificationIdSubmitApproveAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id,
        [JsonContent] Helpdesk.PostHelpdeskV1NotificationsByNotificationIdSubmitApproveBodyDto dto);

    /// <summary>
    /// <para>【服务台】取消审核</para>
    /// <para>接口ID：6999529163292524546</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/cancel_approve</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>提交审核后，如果需要取消审核，则调用此接口。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>唯一ID</para>
    /// <para>示例值：6981801914270744596</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/notifications/{notification_id}/cancel_approve")]
    System.Threading.Tasks.Task<FeishuResponse> PostHelpdeskV1NotificationsByNotificationIdCancelApproveAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id);

    /// <summary>
    /// <para>【服务台】执行推送</para>
    /// <para>接口ID：6999529163292540930</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/execute_send</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>审核通过后调用此接口设置推送时间，等待调度系统调度，发送消息。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>创建接口返回的唯一id</para>
    /// <para>示例值：6985032626234982420</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/notifications/{notification_id}/execute_send")]
    System.Threading.Tasks.Task<FeishuResponse> PostHelpdeskV1NotificationsByNotificationIdExecuteSendAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id,
        [JsonContent] Helpdesk.PostHelpdeskV1NotificationsByNotificationIdExecuteSendBodyDto dto);

    /// <summary>
    /// <para>【服务台】取消推送</para>
    /// <para>接口ID：6999529163292557314</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/cancel_send</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>取消推送接口，审核通过后待调度可以调用，发送过程中可以调用（会撤回已发送的消息），发送完成后可以需要推送（会撤回所有已发送的消息）。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>唯一ID</para>
    /// <para>示例值：6981801914270744596</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/notifications/{notification_id}/cancel_send")]
    System.Threading.Tasks.Task<FeishuResponse> PostHelpdeskV1NotificationsByNotificationIdCancelSendAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id,
        [JsonContent] Helpdesk.PostHelpdeskV1NotificationsByNotificationIdCancelSendBodyDto dto);

    /// <summary>
    /// <para>【服务台】更新推送</para>
    /// <para>接口ID：6999529163292590082</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>更新推送信息，只有在草稿状态下才可以调用此接口进行更新。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>push任务唯一id</para>
    /// <para>示例值：6985032626234982420</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/helpdesk/v1/notifications/{notification_id}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchHelpdeskV1NotificationsByNotificationIdAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id,
        [JsonContent] Helpdesk.PatchHelpdeskV1NotificationsByNotificationIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【服务台】查询推送</para>
    /// <para>接口ID：6999529163292606466</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询推送详情。</para>
    /// </summary>
    /// <param name="notification_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>唯一ID</para>
    /// <para>示例值：1624326025000</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/helpdesk/v1/notifications/{notification_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Helpdesk.GetHelpdeskV1NotificationsByNotificationIdResponseDto>> GetHelpdeskV1NotificationsByNotificationIdAsync(
        UserAccessToken access_token,
        [PathQuery] string notification_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【服务台】创建推送</para>
    /// <para>接口ID：6999529163292639234</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/notification/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用接口创建推送，创建成功后为草稿状态。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/helpdesk/v1/notifications")]
    System.Threading.Tasks.Task<FeishuResponse<Helpdesk.PostHelpdeskV1NotificationsResponseDto>> PostHelpdeskV1NotificationsAsync(
        UserAccessToken access_token,
        [JsonContent] Helpdesk.PostHelpdeskV1NotificationsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新评论</para>
    /// <para>接口ID：6999599891686227970</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-comment/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新评论内容。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论 ID</para>
    /// <para>示例值：6937231762296684564</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/task/v1/tasks/{task_id}/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PutTaskV1TasksByTaskIdCommentsByCommentIdResponseDto>> PutTaskV1TasksByTaskIdCommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string comment_id,
        [JsonContent] Task.PutTaskV1TasksByTaskIdCommentsByCommentIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取评论详情</para>
    /// <para>接口ID：6999599891686244354</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-comment/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于通过评论ID获取评论详情。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论ID</para>
    /// <para>示例值：6937231762296684564</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks/{task_id}/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV1TasksByTaskIdCommentsByCommentIdResponseDto>> GetTaskV1TasksByTaskIdCommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string comment_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】创建评论</para>
    /// <para>接口ID：6999599891686293506</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-comment/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于创建和回复任务的评论。当parent_id字段为0时，为创建评论；当parent_id不为0时，为回复某条评论。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务 ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/comments")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksByTaskIdCommentsResponseDto>> PostTaskV1TasksByTaskIdCommentsAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PostTaskV1TasksByTaskIdCommentsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除评论</para>
    /// <para>接口ID：6999599891686309890</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-comment/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于通过评论ID删除评论。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论ID</para>
    /// <para>示例值：6937231762296684564</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v1/tasks/{task_id}/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV1TasksByTaskIdCommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string comment_id);

    /// <summary>
    /// <para>【绩效】获取绩效结果</para>
    /// <para>接口ID：7000193886257725441</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/review_data/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取绩效结果</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>people_admin_id：以 people_admin_id 来识别用户</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/performance/v1/review_datas/query")]
    System.Threading.Tasks.Task<FeishuResponse<Performance.PostPerformanceV1ReviewDatasQueryResponseDto>> PostPerformanceV1ReviewDatasQueryAsync(
        UserAccessToken access_token,
        [JsonContent] Performance.PostPerformanceV1ReviewDatasQueryBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】获取与会议号关联的会议列表</para>
    /// <para>接口ID：7013251669786116097</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/list_by_no</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定时间范围（90天内)会议号关联的会议简要信息列表。</para>
    /// </summary>
    /// <param name="meeting_no">
    /// <para>必填：是</para>
    /// <para>9位会议号</para>
    /// <para>示例值：123456789</para>
    /// </param>
    /// <param name="start_time">
    /// <para>必填：是</para>
    /// <para>查询开始时间（unix时间，单位sec）</para>
    /// <para>示例值：1608888867</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：是</para>
    /// <para>查询结束时间（unix时间，单位sec）</para>
    /// <para>示例值：1608888867</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：5</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/meetings/list_by_no")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1MeetingsListByNoResponseDto>> GetVcV1MeetingsListByNoAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_no,
        [PathQuery] string start_time,
        [PathQuery] string end_time,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【词典】创建草稿</para>
    /// <para>接口ID：7016992864837271580</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/draft/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>草稿并非词条，而是指通过 API 发起创建新词条或更新现有词条的申请。</para>
    /// <para>词典管理员审核通过后，草稿将变为新的词条或覆盖已有词条。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/drafts")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1DraftsResponseDto>> PostBaikeV1DraftsAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostBaikeV1DraftsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】更新草稿</para>
    /// <para>接口ID：7016992864837287964</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/draft/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 draft_id 更新草稿内容，已审批的草稿无法编辑。</para>
    /// </summary>
    /// <param name="draft_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>草稿 ID</para>
    /// <para>示例值：5347</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/baike/v1/drafts/{draft_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PutBaikeV1DraftsByDraftIdResponseDto>> PutBaikeV1DraftsByDraftIdAsync(
        UserAccessToken access_token,
        [PathQuery] string draft_id,
        [JsonContent] Baike.PutBaikeV1DraftsByDraftIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】获取词条详情</para>
    /// <para>接口ID：7016992864837304348</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过词条 id 拉取对应的词条详情信息。</para>
    /// </summary>
    /// <param name="entity_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>词条 ID</para>
    /// <para>示例值：enterprise_515879</para>
    /// </param>
    /// <param name="provider">
    /// <para>必填：否</para>
    /// <para>外部系统</para>
    /// <para>示例值：星云</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="outer_id">
    /// <para>必填：否</para>
    /// <para>词条在外部系统中对应的唯一 ID</para>
    /// <para>示例值：12345</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/baike/v1/entities/{entity_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetBaikeV1EntitiesByEntityIdResponseDto>> GetBaikeV1EntitiesByEntityIdAsync(
        UserAccessToken access_token,
        [PathQuery] string entity_id,
        [PathQuery] string? provider = null,
        [PathQuery] string? outer_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】获取词条列表</para>
    /// <para>接口ID：7016992864837320732</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>分页拉取词条列表数据，支持拉取租户内的全部词条。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：b152fa6e6f62a291019a04c3a93f365f8ac641910506ff15ff4cad6534e087cb4ed8fa2c</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="provider">
    /// <para>必填：否</para>
    /// <para>相关外部系统【可用来过滤词条数据】</para>
    /// <para>示例值：星云</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/baike/v1/entities")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetBaikeV1EntitiesResponseDto>> GetBaikeV1EntitiesAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? provider = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】精准搜索词条</para>
    /// <para>接口ID：7016992864837337116</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/match</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将关键词与词条名、别名精准匹配，并返回对应的 词条 ID。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/entities/match")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1EntitiesMatchResponseDto>> PostBaikeV1EntitiesMatchAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostBaikeV1EntitiesMatchBodyDto dto);

    /// <summary>
    /// <para>【词典】模糊搜索词条</para>
    /// <para>接口ID：7016992864837353500</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/search</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>传入关键词，与词条名、别名、释义等信息进行模糊匹配，返回搜到的词条信息。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：b152fa6e6f62a291019a04c3a93f365f8ac641910506ff15ff4cad6534e087cb4ed8fa2c</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：b152fa6e6f62a291019a04c3a93f365f8ac641910506ff15ff4cad6534e087cb4ed8fa2c</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/entities/search")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1EntitiesSearchResponseDto>> PostBaikeV1EntitiesSearchAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostBaikeV1EntitiesSearchBodyDto dto,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】词条高亮</para>
    /// <para>接口ID：7016992864837369884</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/highlight</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>传入一句话，智能识别句中对应的词条，并返回词条位置和 entity_id，可在外部系统中快速实现词条智能高亮。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/entities/highlight")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1EntitiesHighlightResponseDto>> PostBaikeV1EntitiesHighlightAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostBaikeV1EntitiesHighlightBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取知识空间子节点列表</para>
    /// <para>接口ID：7023947709203791876</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于分页获取Wiki节点的子节点列表。</para>
    /// <para>此接口为分页接口。由于权限过滤，可能返回列表为空，但分页标记（has_more）为true，可以继续分页请求。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：6946843325487906839</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：6946843325487456878</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="parent_node_token">
    /// <para>必填：否</para>
    /// <para>父节点token</para>
    /// <para>示例值：wikcnKQ1k3p******8Vabce</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/wiki/v2/spaces/{space_id}/nodes")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetWikiV2SpacesBySpaceIdNodesResponseDto>> GetWikiV2SpacesBySpaceIdNodesAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? parent_node_token = null);

    /// <summary>
    /// <para>【云文档】移动云空间文档至知识空间</para>
    /// <para>接口ID：7023947709203808260</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/move_docs_to_wiki</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口允许移动云空间文档至知识空间，并挂载在指定位置</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识库id</para>
    /// <para>示例值：1565676577122621</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces/{space_id}/nodes/move_docs_to_wiki")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiResponseDto>> PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [JsonContent] Ccm.PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新知识空间设置</para>
    /// <para>接口ID：7023947709203824644</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-setting/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据space_id更新知识空间公共设置</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：1565676577122621</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/wiki/v2/spaces/{space_id}/setting")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PutWikiV2SpacesBySpaceIdSettingResponseDto>> PutWikiV2SpacesBySpaceIdSettingAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [JsonContent] Ccm.PutWikiV2SpacesBySpaceIdSettingBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取知识空间列表</para>
    /// <para>接口ID：7023947709203841028</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于获取有权限访问的知识空间列表。</para>
    /// <para>此接口为分页接口。由于权限过滤，可能返回列表为空，但分页标记（has_more）为true，可以继续分页请求。</para>
    /// <para>对于知识空间各项属性描述请参阅[获取知识空间信息](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space/get)</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：1565676577122621</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/wiki/v2/spaces")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetWikiV2SpacesResponseDto>> GetWikiV2SpacesAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【云文档】获取知识空间信息</para>
    /// <para>接口ID：7023947709203857412</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于根据知识空间ID来查询知识空间的信息。</para>
    /// <para>空间类型（type）：</para>
    /// <para>- 个人空间：归个人管理。一人仅可拥有一个个人空间，无法添加其他管理员。</para>
    /// <para>- 团队空间：归团队（多人)管理，可添加多个管理员。</para>
    /// <para>空间可见性（visibility）：</para>
    /// <para>- 公开空间：租户所有用户可见，默认为成员权限。无法额外添加成员，但可以添加管理员。</para>
    /// <para>- 私有空间：仅对知识空间管理员、成员可见，需要手动添加管理员、成员。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：6870403571079249922</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/wiki/v2/spaces/{space_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetWikiV2SpacesBySpaceIdResponseDto>> GetWikiV2SpacesBySpaceIdAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id);

    /// <summary>
    /// <para>【云文档】创建知识空间节点</para>
    /// <para>接口ID：7023947709203873796</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于在知识节点里创建[节点](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-overview)到指定位置。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>[获取方式](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-overview)</para>
    /// <para>示例值：6704147935988285963</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces/{space_id}/nodes")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostWikiV2SpacesBySpaceIdNodesResponseDto>> PostWikiV2SpacesBySpaceIdNodesAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [JsonContent] Ccm.PostWikiV2SpacesBySpaceIdNodesBodyDto dto);

    /// <summary>
    /// <para>【云文档】添加知识空间成员</para>
    /// <para>接口ID：7023947709203906564</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-member/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>添加知识空间成员或管理员。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：1565676577122621</para>
    /// </param>
    /// <param name="need_notification">
    /// <para>必填：否</para>
    /// <para>添加权限后是否通知对方</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces/{space_id}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostWikiV2SpacesBySpaceIdMembersResponseDto>> PostWikiV2SpacesBySpaceIdMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [JsonContent] Ccm.PostWikiV2SpacesBySpaceIdMembersBodyDto dto,
        [PathQuery] bool? need_notification = null);

    /// <summary>
    /// <para>【云文档】创建知识空间</para>
    /// <para>接口ID：7023947709203922948</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>此接口用于创建知识空间</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostWikiV2SpacesResponseDto>> PostWikiV2SpacesAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostWikiV2SpacesBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取知识空间节点信息</para>
    /// <para>接口ID：7023947709203939332</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space/get_node</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取知识空间节点信息</para>
    /// </summary>
    /// <param name="token">
    /// <para>必填：是</para>
    /// <para>文档的token。</para>
    /// <para>使用文档token查询时，需要obj_type参数传入文档对应的类型。</para>
    /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
    /// </param>
    /// <param name="obj_type">
    /// <para>必填：否</para>
    /// <para>文档类型。不传时默认以wiki类型查询。</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>docx：新版文档</item>
    /// <item>sheet：表格</item>
    /// <item>mindnote：思维导图</item>
    /// <item>bitable：多维表格</item>
    /// <item>file：文件</item>
    /// <item>slides：幻灯片</item>
    /// <item>wiki：知识库节点</item>
    /// </list>
    /// <para>默认值：wiki</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/wiki/v2/spaces/get_node")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetWikiV2SpacesGetNodeResponseDto>> GetWikiV2SpacesGetNodeAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string? obj_type = "wiki");

    /// <summary>
    /// <para>【云文档】删除文件或文件夹</para>
    /// <para>接口ID：7029475705897828354</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除用户在云空间内的文件或者文件夹。文件或文件夹被删除后，会进入回收站中。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要删除的文件或文件夹 token。</para>
    /// <para>了解如何获取文件 token，参考[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)。</para>
    /// <para>了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>被删除文件的类型</para>
    /// <para>示例值：file</para>
    /// <list type="bullet">
    /// <item>file：文件类型</item>
    /// <item>docx：新版文档类型</item>
    /// <item>bitable：多维表格类型</item>
    /// <item>folder：文件夹类型</item>
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>mindnote：思维笔记类型</item>
    /// <item>shortcut：快捷方式类型</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/drive/v1/files/{file_token}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.DeleteDriveV1FilesByFileTokenResponseDto>> DeleteDriveV1FilesByFileTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string type);

    /// <summary>
    /// <para>【通讯录】获取部门直属用户列表</para>
    /// <para>接口ID：7033365649318789148</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/find_by_department</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>基于部门ID获取部门直属用户列表。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>部门ID类型的区别参见[部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：以自定义department_id来标识部门</item>
    /// <item>open_department_id：以open_department_id来标识部门</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="department_id">
    /// <para>必填：是</para>
    /// <para>填写该字段表示获取该部门下用户，必填。根部门的部门ID为0。</para>
    /// <para>ID值与查询参数中的department_id_type 对应。</para>
    /// <para>不同 ID 的说明与department_id的获取方式参见 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：od-xxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/users/find_by_department")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3UsersFindByDepartmentResponseDto>> GetContactV3UsersFindByDepartmentAsync(
        UserAccessToken access_token,
        [PathQuery] string department_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【通讯录】获取子部门列表</para>
    /// <para>接口ID：7033365649318805532</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/children</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过部门ID获取部门的子部门列表。</para>
    /// </summary>
    /// <param name="department_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>部门ID，根部门的部门ID 为0</para>
    /// <para>department_id的获取方式参见 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：D096</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的部门ID的类型</para>
    /// <para>不同 ID 的说明与department_id的获取方式参见 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>department_id：用来标识租户内一个唯一的部门</item>
    /// <item>open_department_id：用来在具体某个应用中标识一个部门，同一个部门 在不同应用中的 open_department_id 相同。</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="fetch_child">
    /// <para>必填：否</para>
    /// <para>是否递归获取子部门</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/departments/{department_id}/children")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3DepartmentsByDepartmentIdChildrenResponseDto>> GetContactV3DepartmentsByDepartmentIdChildrenAsync(
        UserAccessToken access_token,
        [PathQuery] string department_id,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] bool? fetch_child = null,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【云文档】获取任务结果</para>
    /// <para>接口ID：7041549010980634626</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/task/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该方法用于获取wiki异步任务的结果</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务id</para>
    /// <para>示例值：7037044037068177428-075c9481e6a0007c1df689dfbe5b55a08b6b06f7</para>
    /// </param>
    /// <param name="task_type">
    /// <para>必填：是</para>
    /// <para>任务类型</para>
    /// <para>示例值：move</para>
    /// <list type="bullet">
    /// <item>move：[移动云空间文档至知识空间](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/move_docs_to_wiki)任务</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/wiki/v2/tasks/{task_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetWikiV2TasksByTaskIdResponseDto>> GetWikiV2TasksByTaskIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] string task_type);

    /// <summary>
    /// <para>【云文档】删除知识空间成员</para>
    /// <para>接口ID：7041549010980651010</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-member/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于删除知识空间成员或管理员。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：7008061636015554580</para>
    /// </param>
    /// <param name="member_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>成员id，值的类型由请求体的 member_type 参数决定</para>
    /// <para>示例值：g64fb7g7</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/wiki/v2/spaces/{space_id}/members/{member_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.DeleteWikiV2SpacesBySpaceIdMembersByMemberIdResponseDto>> DeleteWikiV2SpacesBySpaceIdMembersByMemberIdAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [PathQuery] string member_id,
        [JsonContent] Ccm.DeleteWikiV2SpacesBySpaceIdMembersByMemberIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】移动知识空间节点</para>
    /// <para>接口ID：7041549010980667394</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/move</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此方法用于在Wiki内移动节点，支持跨知识空间移动。如果有子节点，会携带子节点一起移动。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：7008061636015512345</para>
    /// </param>
    /// <param name="node_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要迁移的节点token</para>
    /// <para>示例值：wikbcd6ydSUyOEzbdlt1BfpA5Yc</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces/{space_id}/nodes/{node_token}/move")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveResponseDto>> PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [PathQuery] string node_token,
        [JsonContent] Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】更新群置顶</para>
    /// <para>接口ID：7043611687799816193</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-top_notice/put_top_notice</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新会话中的群置顶信息，可以将群中的某一条消息，或者群公告置顶显示。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待修改置顶的群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/top_notice/put_top_notice")]
    System.Threading.Tasks.Task<FeishuResponse> PostImV1ChatsByChatIdTopNoticePutTopNoticeAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdTopNoticePutTopNoticeBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】撤销群置顶</para>
    /// <para>接口ID：7043624153760759810</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-top_notice/delete_top_notice</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>撤销会话中的置顶。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待撤销置顶的群 ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_5ad11d72b830411d72b836c20</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/top_notice/delete_top_notice")]
    System.Threading.Tasks.Task<FeishuResponse> PostImV1ChatsByChatIdTopNoticeDeleteTopNoticeAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id);

    /// <summary>
    /// <para>【任务】查询所有任务</para>
    /// <para>接口ID：7044355281854070812</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>以分页的方式获取任务列表。当使用user_access_token时，获取与该用户身份相关的所有任务。当使用tenant_access_token时，获取以该应用身份通过“创建任务“接口创建的所有任务（并非获取该应用所在租户下所有用户创建的任务）。</para>
    /// <para>本接口支持通过任务创建时间以及任务的完成状态对任务进行过滤。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：MTYzMTg3ODUxNQ==</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="start_create_time">
    /// <para>必填：否</para>
    /// <para>范围查询任务时，查询的起始时间。不填时默认起始时间为第一个任务的创建时间。</para>
    /// <para>示例值：1652323331</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="end_create_time">
    /// <para>必填：否</para>
    /// <para>范围查询任务时，查询的结束时间。不填时默认结束时间为最后一个任务的创建时间。</para>
    /// <para>示例值：1652323335</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="task_completed">
    /// <para>必填：否</para>
    /// <para>可用于查询时过滤任务完成状态。true表示只返回已完成的任务，false表示只返回未完成的任务。不填时表示同时返回两种完成状态的任务。</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV1TasksResponseDto>> GetTaskV1TasksAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? start_create_time = null,
        [PathQuery] string? end_create_time = null,
        [PathQuery] bool? task_completed = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【OKR】上传进展记录图片</para>
    /// <para>接口ID：7047048928294174722</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/image/upload</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>上传进展记录图片。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="data">
    /// <para>必填：是</para>
    /// <para>图片</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/okr/v1/images/upload")]
    System.Threading.Tasks.Task<FeishuResponse<Okr.PostOkrV1ImagesUploadResponseDto>> PostOkrV1ImagesUploadAsync(
        UserAccessToken access_token,
        [FormDataContent] Okr.PostOkrV1ImagesUploadBodyDto dto,
        [FormDataContent] FormDataFile data);

    /// <summary>
    /// <para>【OKR】创建 OKR 进展记录</para>
    /// <para>接口ID：7047048928294944770</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/progress_record/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建 OKR 进展记录。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/okr/v1/progress_records")]
    System.Threading.Tasks.Task<FeishuResponse<Okr.PostOkrV1ProgressRecordsResponseDto>> PostOkrV1ProgressRecordsAsync(
        UserAccessToken access_token,
        [JsonContent] Okr.PostOkrV1ProgressRecordsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【OKR】更新 OKR 进展记录</para>
    /// <para>接口ID：7047052132604870684</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/progress_record/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 OKR 进展记录 ID 更新进展详情。</para>
    /// </summary>
    /// <param name="progress_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待更新的 OKR进展记录 ID</para>
    /// <para>示例值：7041857032248410131</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/okr/v1/progress_records/{progress_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Okr.PutOkrV1ProgressRecordsByProgressIdResponseDto>> PutOkrV1ProgressRecordsByProgressIdAsync(
        UserAccessToken access_token,
        [PathQuery] string progress_id,
        [JsonContent] Okr.PutOkrV1ProgressRecordsByProgressIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【OKR】删除 OKR 进展记录</para>
    /// <para>接口ID：7047056455665532929</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/progress_record/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 ID 删除 OKR 进展记录。</para>
    /// </summary>
    /// <param name="progress_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待删除的 OKR进展记录 ID</para>
    /// <para>示例值：7041857032248410131</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/okr/v1/progress_records/{progress_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteOkrV1ProgressRecordsByProgressIdAsync(
        UserAccessToken access_token,
        [PathQuery] string progress_id);

    /// <summary>
    /// <para>【OKR】获取 OKR 进展记录</para>
    /// <para>接口ID：7047056455665926145</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/progress_record/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 ID 获取 OKR 进展记录详情。</para>
    /// </summary>
    /// <param name="progress_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待查询的 OKR进展记录 ID</para>
    /// <para>示例值：7041857032248410131</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/okr/v1/progress_records/{progress_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Okr.GetOkrV1ProgressRecordsByProgressIdResponseDto>> GetOkrV1ProgressRecordsByProgressIdAsync(
        UserAccessToken access_token,
        [PathQuery] string progress_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】创建多维表格</para>
    /// <para>接口ID：7047733935745007620</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>在指定目录下创建多维表格</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsResponseDto>> PostBitableV1AppsAsync(
        UserAccessToken access_token,
        [JsonContent] Base.PostBitableV1AppsBodyDto dto);

    /// <summary>
    /// <para>【日历】查询主日历信息</para>
    /// <para>接口ID：7051880392425439236</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口获取当前身份（应用或用户）的主日历信息。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/primary")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsPrimaryResponseDto>> PostCalendarV4CalendarsPrimaryAsync(
        UserAccessToken access_token,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】创建订阅</para>
    /// <para>接口ID：7065964758428483612</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-subscription/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>订阅文档中的变更事件，当前支持文档评论订阅，订阅后文档评论更新会有“云文档助手”推送给订阅的用户</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doxcnxxxxxxxxxxxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/subscriptions")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesByFileTokenSubscriptionsResponseDto>> PostDriveV1FilesByFileTokenSubscriptionsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [JsonContent] Ccm.PostDriveV1FilesByFileTokenSubscriptionsBodyDto dto);

    /// <summary>
    /// <para>【云文档】更新订阅状态</para>
    /// <para>接口ID：7065964758428499996</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-subscription/patch</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>根据订阅ID更新订阅状态</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doxcnxxxxxxxxxxxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="subscription_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>订阅关系ID</para>
    /// <para>示例值：1234567890987654321</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/drive/v1/files/{file_token}/subscriptions/{subscription_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdResponseDto>> PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string subscription_id,
        [JsonContent] Ccm.PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取订阅状态</para>
    /// <para>接口ID：7065964758428516380</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-subscription/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>根据订阅ID获取该订阅的状态</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doxcnxxxxxxxxxxxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="subscription_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>订阅关系ID</para>
    /// <para>示例值：1234567890987654321</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/subscriptions/{subscription_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdResponseDto>> GetDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string subscription_id,
        [JsonContent] Ccm.GetDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】创建文档</para>
    /// <para>接口ID：7068199542315204636</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建文档类型为 docx 的文档。你可选择传入文档标题和文件夹。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/docx/v1/documents")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDocxV1DocumentsResponseDto>> PostDocxV1DocumentsAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDocxV1DocumentsBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取所有子块</para>
    /// <para>接口ID：7068199542315253788</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给定一个指定版本的文档，并指定需要操作的块，分页遍历其所有子块富文本内容 。如果不指定版本，则会默认查询最新版本。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="block_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Block 的唯一标识</para>
    /// <para>示例值：doxcnO6UW6wAw2qIcYf4hZpFIth</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>操作的文档版本，-1表示文档最新版本。若此时操作的版本为文档最新版本，则需要持有文档的阅读权限；若此时操作的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aw7DoMKBFMOGwqHCrcO8w6jCmMOvw6ILeADCvsKNw57Di8O5XGV3LG4_w5HCqhFxSnDCrCzCn0BgZcOYUg85EMOYcEAcwqYOw4ojw5QFwofCu8KoIMO3K8Ktw4IuNMOBBHNYw4bCgCV3U1zDu8K-J8KSR8Kgw7Y0fsKZdsKvW3d9w53DnkHDrcO5bDkYwrvDisOEPcOtVFJ-I03CnsOILMOoAmLDknd6dsKqG1bClAjDuS3CvcOTwo7Dg8OrwovDsRdqIcKxw5HDohTDtXN9w5rCkWo</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：500</para>
    /// <para>默认值：500</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/docx/v1/documents/{document_id}/blocks/{block_id}/children")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto>> GetDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] string block_id,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 500,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】创建块</para>
    /// <para>接口ID：7068199542315270172</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>指定需要操作的块，为其创建一批子块，并插入到指定位置。如果操作成功，接口将返回新创建子块的富文本内容。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="block_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Block 的唯一标识</para>
    /// <para>示例值：doxcnO6UW6wAw2qIcYf4hZpFIth</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>操作的文档版本，-1 表示文档最新版本。若此时操作的版本为文档最新版本，则需要持有文档的阅读权限；若此时操作的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>操作的唯一标识，与接口返回值的 client_token 相对应，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/docx/v1/documents/{document_id}/blocks/{block_id}/children")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto>> PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] string block_id,
        [JsonContent] Ccm.PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBodyDto dto,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? client_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】更新块的内容</para>
    /// <para>接口ID：7068199542315286556</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新指定的块。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="block_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Block 的唯一标识</para>
    /// <para>示例值：doxcnO6UW6wAw2qIcYf4hZpFIth</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>操作的文档版本，-1 表示文档最新版本。若此时操作的版本为文档最新版本，则需要持有文档的阅读权限；若此时操作的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>操作的唯一标识，与接口返回值的 client_token 相对应，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/docx/v1/documents/{document_id}/blocks/{block_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto>> PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] string block_id,
        [JsonContent] Ccm.PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdBodyDto dto,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? client_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取文档基本信息</para>
    /// <para>接口ID：7068199542315302940</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取文档标题和最新版本 ID。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档的唯一标识。点击[这里](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-overview)了解如何获取文档的 `document_id`</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Iabcef</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/docx/v1/documents/{document_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDocxV1DocumentsByDocumentIdResponseDto>> GetDocxV1DocumentsByDocumentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id);

    /// <summary>
    /// <para>【云文档】删除块</para>
    /// <para>接口ID：7068199542315335708</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/batch_delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>指定需要操作的块，删除其指定范围的子块。如果操作成功，接口将返回应用删除操作后的文档版本号。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="block_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>父 Block 的唯一标识</para>
    /// <para>示例值：doxcnO6UW6wAw2qIcYf4hZpFIth</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>操作的文档版本，-1表示文档最新版本。若此时操作的版本为文档最新版本，则需要持有文档的阅读权限；若此时操作的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>操作的唯一标识，与接口返回值的 client_token 相对应，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/docx/v1/documents/{document_id}/blocks/{block_id}/children/batch_delete")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.DeleteDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBatchDeleteResponseDto>> DeleteDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBatchDeleteAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] string block_id,
        [JsonContent] Ccm.DeleteDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBatchDeleteBodyDto dto,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? client_token = null);

    /// <summary>
    /// <para>【云文档】获取文档所有块</para>
    /// <para>接口ID：7068199542315352092</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取文档所有块的富文本内容并分页返回。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档的唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：500</para>
    /// <para>默认值：500</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aw7DoMKBFMOGwqHCrcO8w6jCmMOvw6ILeADCvsKNw57Di8O5XGV3LG4_w5HCqhFxSnDCrCzCn0BgZcOYUg85EMOYcEAcwqYOw4ojw5QFwofCu8KoIMO3K8Ktw4IuNMOBBHNYw4bCgCV3U1zDu8K-J8KSR8Kgw7Y0fsKZdsKvW3d9w53DnkHDrcO5bDkYwrvDisOEPcOtVFJ-I03CnsOILMOoAmLDknd6dsKqG1bClAjDuS3CvcOTwo7Dg8OrwovDsRdqIcKxw5HDohTDtXN9w5rCkWo</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>查询的文档版本，-1表示文档最新版本。若此时查询的版本为文档最新版本，则需要持有文档的阅读权限；若此时查询的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/docx/v1/documents/{document_id}/blocks")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDocxV1DocumentsByDocumentIdBlocksResponseDto>> GetDocxV1DocumentsByDocumentIdBlocksAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] int? page_size = 500,
        [PathQuery] string? page_token = null,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取块的内容</para>
    /// <para>接口ID：7068199542315368476</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定块的富文本内容。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="block_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Block 的唯一标识</para>
    /// <para>示例值：doxcnO6UW6wAw2qIcYf4hZpFIth</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>查询的文档版本，-1 表示文档最新版本。若此时查询的版本为文档最新版本，则需要持有文档的阅读权限；若此时查询的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/docx/v1/documents/{document_id}/blocks/{block_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto>> GetDocxV1DocumentsByDocumentIdBlocksByBlockIdAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] string block_id,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】更新多维表格元数据</para>
    /// <para>接口ID：7073673019918811164</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过 app_token 更新多维表格元数据</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>Base app token</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/bitable/v1/apps/{app_token}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PutBitableV1AppsByAppTokenResponseDto>> PutBitableV1AppsByAppTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [JsonContent] Base.PutBitableV1AppsByAppTokenBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取文档纯文本内容</para>
    /// <para>接口ID：7079983676051013634</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/raw_content</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取文档的纯文本内容。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档的唯一标识。点击[这里](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-overview)了解如何获取文档的 `document_id`</para>
    /// <para>示例值：doxbcmEtbFrbbq10nPNu8gabcef</para>
    /// </param>
    /// <param name="lang">
    /// <para>必填：否</para>
    /// <para>指定返回的 MentionUser 即 @用户 的语言</para>
    /// <para>示例值：0</para>
    /// <list type="bullet">
    /// <item>0：该用户的默认名称。如：@张敏</item>
    /// <item>1：该用户的英文名称。如：@Min Zhang</item>
    /// <item>2：暂不支持该枚举，使用时返回该用户的默认名称</item>
    /// </list>
    /// <para>默认值：0</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/docx/v1/documents/{document_id}/raw_content")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDocxV1DocumentsByDocumentIdRawContentResponseDto>> GetDocxV1DocumentsByDocumentIdRawContentAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [PathQuery] int? lang = 0);

    /// <summary>
    /// <para>【云文档】移动文件或文件夹</para>
    /// <para>接口ID：7080903916725993474</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/move</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将文件或者文件夹移动到用户云空间的其他位置。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要移动的文件或文件夹 token。</para>
    /// <para>了解如何获取文件 token，参考[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)。</para>
    /// <para>了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/move")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesByFileTokenMoveResponseDto>> PostDriveV1FilesByFileTokenMoveAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [JsonContent] Ccm.PostDriveV1FilesByFileTokenMoveBodyDto dto);

    /// <summary>
    /// <para>【词典】创建免审词条</para>
    /// <para>接口ID：7085379347152044034</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过此接口创建的词条，无需经过词典管理员审核，直接写入词库。因此，调用此接口时，应当慎重操作。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/entities")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1EntitiesResponseDto>> PostBaikeV1EntitiesAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostBaikeV1EntitiesBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】更新免审词条</para>
    /// <para>接口ID：7085379347152060418</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过此接口更新已有的词条，无需经过词典管理员审核，直接写入词库。</para>
    /// <para>因此，调用该接口时应当慎重操作。</para>
    /// </summary>
    /// <param name="entity_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>实体词 ID</para>
    /// <para>示例值：enterprise_40217521</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/baike/v1/entities/{entity_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PutBaikeV1EntitiesByEntityIdResponseDto>> PutBaikeV1EntitiesByEntityIdAsync(
        UserAccessToken access_token,
        [PathQuery] string entity_id,
        [JsonContent] Baike.PutBaikeV1EntitiesByEntityIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】获取词典分类</para>
    /// <para>接口ID：7085379347152076802</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/classification/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取飞书词典当前分类。</para>
    /// <para>飞书词典目前为二级分类体系，每个词条可添加多个二级分类，但选择的二级分类必须从属于不同的一级分类。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：408ecac018b2e3518db37275e812****bb8ad3e755fc886f322ac6c430ba</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/baike/v1/classifications")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetBaikeV1ClassificationsResponseDto>> GetBaikeV1ClassificationsAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【云文档】新建文件夹</para>
    /// <para>接口ID：7086652480830914563</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/create_folder</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于在用户云空间指定文件夹中创建一个空文件夹。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/create_folder")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesCreateFolderResponseDto>> PostDriveV1FilesCreateFolderAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1FilesCreateFolderBodyDto dto);

    /// <summary>
    /// <para>【云文档】复制文件</para>
    /// <para>接口ID：7087776630140157955</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/copy</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于将用户云空间中的文件复制至其它文件夹下。不支持复制文件夹。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>被复制的源文件的 token。了解如何获取文件 token，参考[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)。</para>
    /// <para>示例值：doccngpahSdXrFPIBD4XdIabcef</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/copy")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesByFileTokenCopyResponseDto>> PostDriveV1FilesByFileTokenCopyAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [JsonContent] Ccm.PostDriveV1FilesByFileTokenCopyBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】创建导出任务</para>
    /// <para>接口ID：7089034521211191298</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于创建导出文件的任务，并返回导出任务 ID。导出文件指将飞书文档、电子表格、多维表格导出为本地文件，包括 Word、Excel、PDF、CSV 格式。该接口为异步接口，需要继续调用[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)接口获取导出结果。了解完整的导出步骤，参考[导出云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/export_tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1ExportTasksResponseDto>> PostDriveV1ExportTasksAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1ExportTasksBodyDto dto);

    /// <summary>
    /// <para>【云文档】查询导出任务结果</para>
    /// <para>接口ID：7089034521211207682</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据[创建导出任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/create)返回的导出任务 ID（ticket）轮询导出任务结果，并返回导出文件的 token。你可使用该 token 继续调用[下载导出文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/download)接口将导出的产物下载到本地。了解完整的导出文件步骤，参考[导出飞书云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
    /// </summary>
    /// <param name="ticket">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>导出任务 ID。调用[创建导出任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/create) 获取。</para>
    /// <para>示例值：6933093124755412345</para>
    /// </param>
    /// <param name="token">
    /// <para>必填：是</para>
    /// <para>要导出的云文档的 token。获取方式参考[如何获取云文档相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。你可参考以下请求示例了解如何使用查询参数。</para>
    /// <para>示例值：docbcZVGtv1papC6jAVGiyabcef</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/export_tasks/{ticket}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1ExportTasksByTicketResponseDto>> GetDriveV1ExportTasksByTicketAsync(
        UserAccessToken access_token,
        [PathQuery] string ticket,
        [PathQuery] string token);

    /// <summary>
    /// <para>【云文档】获取云文档权限设置</para>
    /// <para>接口ID：7091106167506354178</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-public/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 获取云文档的权限设置。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/permissions/{token}/public")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1PermissionsByTokenPublicResponseDto>> GetDriveV1PermissionsByTokenPublicAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type);

    /// <summary>
    /// <para>【云文档】下载导出文件</para>
    /// <para>接口ID：7091583486251335682</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/download</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)返回的导出文件的 token，下载导出产物到本地。了解完整的导出文件步骤，参考[导出云文档概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/export-user-guide)。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>导出的文件的 token。可通过调用[查询导出任务结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/export_task/get)获取该参数的值。</para>
    /// <para>示例值：boxcnxe5OdjlAkNgSNdsJvabcef</para>
    /// </param>
    /// <returns>返回文件二进制流</returns>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/export_tasks/file/{file_token}/download")]
    System.Threading.Tasks.Task<HttpResponseMessage> GetDriveV1ExportTasksFileByFileTokenDownloadAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token);

    /// <summary>
    /// <para>【云文档】订阅云文档事件</para>
    /// <para>接口ID：7094878915034464284</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/subscribe</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口仅支持**文档拥有者**和**文档管理者**订阅文档的通知事件（但目前文档管理者仅能接收到**文件编辑**事件）。可订阅的文档类型为**旧版文档**、**新版文档**、**电子表格**和**多维表格**。在调用该接口之前请确保正确[配置事件回调网址和订阅事件类型](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM#2eb3504a)，目前已支持的事件类型请参考[事件列表](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-list)。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doccnxxxxxxxxxxxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>docx：新版文档</item>
    /// <item>sheet：表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>folder：文件夹</item>
    /// </list>
    /// </param>
    /// <param name="event_type">
    /// <para>必填：否</para>
    /// <para>事件类型，订阅为folder类型时必填</para>
    /// <para>示例值：file.created_in_folder_v1</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/subscribe")]
    System.Threading.Tasks.Task<FeishuResponse> PostDriveV1FilesByFileTokenSubscribeAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [PathQuery] string? event_type = null);

    /// <summary>
    /// <para>【云文档】查询异步任务状态</para>
    /// <para>接口ID：7094912924435021826</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/task_check</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询异步任务的状态信息。目前支持查询删除文件夹和移动文件夹的异步任务。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>必填：是</para>
    /// <para>异步任务的 ID。目前支持查询删除文件夹和移动文件夹的异步任务。可通过调用[删除文件夹](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete)或[移动文件夹](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/move)获取任务 ID</para>
    /// <para>示例值：7360595374803812356</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/task_check")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesTaskCheckResponseDto>> GetDriveV1FilesTaskCheckAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id);

    /// <summary>
    /// <para>【云文档】批量更新块的内容</para>
    /// <para>接口ID：7100866542866530308</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/batch_update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>批量更新块的富文本内容。</para>
    /// </summary>
    /// <param name="document_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>示例值：doxcnePuYufKa49ISjhD8Ih0ikh</para>
    /// </param>
    /// <param name="document_revision_id">
    /// <para>必填：否</para>
    /// <para>操作的文档版本，-1 表示文档最新版本。若此时操作的版本为文档最新版本，则需要持有文档的阅读权限；若此时操作的版本为文档的历史版本，则需要持有文档的编辑权限。</para>
    /// <para>示例值：-1</para>
    /// <para>默认值：-1</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>操作的唯一标识，与接口返回值的 client_token 相对应，用于幂等的进行更新操作。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的用户ID的类型</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/docx/v1/documents/{document_id}/blocks/batch_update")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateResponseDto>> PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateAsync(
        UserAccessToken access_token,
        [PathQuery] string document_id,
        [JsonContent] Ccm.PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateBodyDto dto,
        [PathQuery] int? document_revision_id = -1,
        [PathQuery] string? client_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】新增协作者</para>
    /// <para>接口ID：7101134500528619523</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role-member/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>新增自定义角色的协作者</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色的id</para>
    /// <para>示例值：roljRpwIUt</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>协作者id类型，与请求体中的member_id要对应</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：以open_id来识别协作者</item>
    /// <item>union_id：以union_id来识别协作者</item>
    /// <item>user_id：以user_id来识别协作者</item>
    /// <item>chat_id：以chat_id来识别协作者</item>
    /// <item>department_id：以department_id来识别协作者</item>
    /// <item>open_department_id：以open_department_id来识别协作者</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}/members")]
    System.Threading.Tasks.Task<FeishuResponse> PostBitableV1AppsByAppTokenRolesByRoleIdMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenRolesByRoleIdMembersBodyDto dto,
        [PathQuery] string? member_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】删除自定义角色</para>
    /// <para>接口ID：7101134500528635907</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除自定义角色</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色的id</para>
    /// <para>示例值：roljRpwIUt</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteBitableV1AppsByAppTokenRolesByRoleIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id);

    /// <summary>
    /// <para>【多维表格】更新自定义角色</para>
    /// <para>接口ID：7101134500528652291</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新自定义角色</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色的id</para>
    /// <para>示例值：roljRpwIUt</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PutBitableV1AppsByAppTokenRolesByRoleIdResponseDto>> PutBitableV1AppsByAppTokenRolesByRoleIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id,
        [JsonContent] Base.PutBitableV1AppsByAppTokenRolesByRoleIdBodyDto dto);

    /// <summary>
    /// <para>【多维表格】列出协作者</para>
    /// <para>接口ID：7101134500528668675</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role-member/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列出自定义角色的协作者</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色的id</para>
    /// <para>示例值：roljRpwIUt</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：100</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：xxxxx</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenRolesByRoleIdMembersResponseDto>> GetBitableV1AppsByAppTokenRolesByRoleIdMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【多维表格】列出自定义角色</para>
    /// <para>接口ID：7101134500528701443</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列出自定义角色</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：roljRpwIUt</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/roles")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenRolesResponseDto>> GetBitableV1AppsByAppTokenRolesAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【多维表格】删除协作者</para>
    /// <para>接口ID：7101134500528717827</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role-member/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除自定义角色的协作者</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色的id</para>
    /// <para>示例值：roljRpwIUt</para>
    /// </param>
    /// <param name="member_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>协作者id</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad53uew2</para>
    /// </param>
    /// <param name="member_id_type">
    /// <para>必填：否</para>
    /// <para>协作者id类型，与请求体中的member_id要对应</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：以open_id来识别协作者</item>
    /// <item>union_id：以union_id来识别协作者</item>
    /// <item>user_id：以user_id来识别协作者</item>
    /// <item>chat_id：以chat_id来识别协作者</item>
    /// <item>department_id：以department_id来识别协作者</item>
    /// <item>open_department_id：以open_department_id来识别协作者</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}/members/{member_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteBitableV1AppsByAppTokenRolesByRoleIdMembersByMemberIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id,
        [PathQuery] string member_id,
        [PathQuery] string? member_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】新增自定义角色</para>
    /// <para>接口ID：7101134500528734211</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>新增自定义角色</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：appbcbWCzen6D8dezhoCH2RpMAh</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/roles")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenRolesResponseDto>> PostBitableV1AppsByAppTokenRolesAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [JsonContent] Base.PostBitableV1AppsByAppTokenRolesBodyDto dto);

    /// <summary>
    /// <para>【任务】获取评论列表</para>
    /// <para>接口ID：7104611925149581315</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task-comment/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于查询任务评论列表，支持分页，最大值为100。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务id</para>
    /// <para>示例值："83912691-2e43-47fc-94a4-d512e03984fa"</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值："MTYzMTg3ODUxNQ=="</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="list_direction">
    /// <para>必填：否</para>
    /// <para>评论排序标记，可按照评论时间从小到大查询，或者评论时间从大到小查询，不填默认按照从小到大</para>
    /// <para>示例值：0</para>
    /// <list type="bullet">
    /// <item>0：按照回复时间从小到大查询</item>
    /// <item>1：按照回复时间从大到小查询</item>
    /// </list>
    /// <para>默认值：0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v1/tasks/{task_id}/comments")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV1TasksByTaskIdCommentsResponseDto>> GetTaskV1TasksByTaskIdCommentsAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] int? list_direction = 0,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取文件元数据</para>
    /// <para>接口ID：7106040876741345308</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/meta/batch_query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件 token 获取其元数据，包括标题、所有者、创建时间、密级、访问链接等数据。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/metas/batch_query")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1MetasBatchQueryResponseDto>> PostDriveV1MetasBatchQueryAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1MetasBatchQueryBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取文件夹中的文件清单</para>
    /// <para>接口ID：7108600920377016348</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取用户云空间指定文件夹中文件信息清单。文件的信息包括名称、类型、token、创建时间、所有者 ID 等。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>指定每页显示的数据项的数量。若获取根目录下的清单，将返回全部数据，不支持分页</para>
    /// <para>示例值：50</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：MTY1NTA3MTA1OXw3MTA4NDc2MDc1NzkyOTI0Nabcef</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="folder_token">
    /// <para>必填：否</para>
    /// <para>文件夹的 token。不填写或填空字符串，将获取用户云空间根目录下的清单，且不支持分页。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a9abcef</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="order_by">
    /// <para>必填：否</para>
    /// <para>定义清单中文件的排序方式</para>
    /// <para>示例值：EditedTime</para>
    /// <list type="bullet">
    /// <item>EditedTime：按编辑时间排序</item>
    /// <item>CreatedTime：按创建时间排序</item>
    /// </list>
    /// <para>默认值：EditedTime</para>
    /// </param>
    /// <param name="direction">
    /// <para>必填：否</para>
    /// <para>定义清单中文件的排序规则</para>
    /// <para>示例值：DESC</para>
    /// <list type="bullet">
    /// <item>ASC：按升序排序</item>
    /// <item>DESC：按降序排序</item>
    /// </list>
    /// <para>默认值：DESC</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesResponseDto>> GetDriveV1FilesAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? folder_token = null,
        [PathQuery] string? order_by = "EditedTime",
        [PathQuery] string? direction = "DESC",
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】更新知识空间节点标题</para>
    /// <para>接口ID：7109718703113781251</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/update_title</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于更新节点标题</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间ID</para>
    /// <para>示例值：6946843325487912356</para>
    /// </param>
    /// <param name="node_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>节点token</para>
    /// <para>示例值：wikcnKQ1k3pcuo5uSK4t8Vabcef</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces/{space_id}/nodes/{node_token}/update_title")]
    System.Threading.Tasks.Task<FeishuResponse> PostWikiV2SpacesBySpaceIdNodesByNodeTokenUpdateTitleAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [PathQuery] string node_token,
        [JsonContent] Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenUpdateTitleBodyDto dto);

    /// <summary>
    /// <para>【云文档】创建知识空间节点副本</para>
    /// <para>接口ID：7109718703113797635</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/space-node/copy</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口用于在知识空间创建节点副本到指定位置。</para>
    /// </summary>
    /// <param name="space_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>知识空间id</para>
    /// <para>示例值：6946843325487912356</para>
    /// </param>
    /// <param name="node_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>节点token</para>
    /// <para>示例值：wikcnKQ1k3p******8Vabce</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/wiki/v2/spaces/{space_id}/nodes/{node_token}/copy")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyResponseDto>> PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyAsync(
        UserAccessToken access_token,
        [PathQuery] string space_id,
        [PathQuery] string node_token,
        [JsonContent] Ccm.PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】添加会话标签页</para>
    /// <para>接口ID：7111246605500563457</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>添加自定义会话标签页。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：支持群模式为`p2p`与`group`的群ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/chat_tabs")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdChatTabsResponseDto>> PostImV1ChatsByChatIdChatTabsAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdChatTabsBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】删除会话标签页</para>
    /// <para>接口ID：7111246605500579841</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/delete_tabs</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除会话标签页。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：支持群模式为`p2p`与`group`的群ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/im/v1/chats/{chat_id}/chat_tabs/delete_tabs")]
    System.Threading.Tasks.Task<FeishuResponse<Im.DeleteImV1ChatsByChatIdChatTabsDeleteTabsResponseDto>> DeleteImV1ChatsByChatIdChatTabsDeleteTabsAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.DeleteImV1ChatsByChatIdChatTabsDeleteTabsBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】拉取会话标签页</para>
    /// <para>接口ID：7111246605500596225</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/list_tabs</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>拉取会话标签页。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：支持群模式为`p2p`与`group`的群ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/chats/{chat_id}/chat_tabs/list_tabs")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1ChatsByChatIdChatTabsListTabsResponseDto>> GetImV1ChatsByChatIdChatTabsListTabsAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id);

    /// <summary>
    /// <para>【消息与群组】更新会话标签页</para>
    /// <para>接口ID：7111246605500612609</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/update_tabs</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新会话标签页。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：支持群模式为`p2p`与`group`的群ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/chat_tabs/update_tabs")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdChatTabsUpdateTabsResponseDto>> PostImV1ChatsByChatIdChatTabsUpdateTabsAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdChatTabsUpdateTabsBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】会话标签页排序</para>
    /// <para>接口ID：7111246605500628993</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/sort_tabs</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>会话标签页排序。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>群ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：支持群模式为`p2p`与`group`的群ID</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/chat_tabs/sort_tabs")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdChatTabsSortTabsResponseDto>> PostImV1ChatsByChatIdChatTabsSortTabsAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdChatTabsSortTabsBodyDto dto);

    /// <summary>
    /// <para>【多维表格】批量删除协作者</para>
    /// <para>接口ID：7111246853309071363</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role-member/batch_delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>批量删除自定义角色的协作者</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格文档 Token</para>
    /// <para>示例值：bascnnKKvcoUblgmmhZkYqabcef</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色 ID</para>
    /// <para>示例值：rolNGhPqks</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}/members/batch_delete")]
    System.Threading.Tasks.Task<FeishuResponse> PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchDeleteAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchDeleteBodyDto dto);

    /// <summary>
    /// <para>【多维表格】批量新增协作者</para>
    /// <para>接口ID：7111246853309087747</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role-member/batch_create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>批量新增自定义角色的协作者</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：bascnnKKvcoUblgmmhZkYqabcef</para>
    /// </param>
    /// <param name="role_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义角色 ID</para>
    /// <para>示例值：rolNGhPqks</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/roles/{role_id}/members/batch_create")]
    System.Threading.Tasks.Task<FeishuResponse> PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchCreateAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string role_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchCreateBodyDto dto);

    /// <summary>
    /// <para>【多维表格】更新表单问题</para>
    /// <para>接口ID：7112628058154893314</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form-field/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新表单中的问题项</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格文档 Token</para>
    /// <para>**示例值**："bascnCMII2ORej2RItqpZZUNMIe"</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 ID</para>
    /// <para>**示例值**："tblsRc9GRRXKqhvW"</para>
    /// </param>
    /// <param name="form_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表单 ID</para>
    /// <para>**示例值**："vewTpR1urY"</para>
    /// </param>
    /// <param name="field_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表单问题 ID</para>
    /// <para>**示例值**："fldjX7dUj5"</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/forms/{form_id}/fields/{field_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.Spec.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdResponseDto>> PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string form_id,
        [PathQuery] string field_id,
        [JsonContent] Base.Spec.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto dto);

    /// <summary>
    /// <para>【多维表格】列出表单问题</para>
    /// <para>接口ID：7112628058154909698</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form-field/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列出表单的所有问题项</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格文档 Token</para>
    /// <para>示例值：bascnCMII2ORej2RItqpZZUNMIe</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 ID</para>
    /// <para>示例值：tblxI2tWaxP5dG7p</para>
    /// </param>
    /// <param name="form_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表单 ID</para>
    /// <para>示例值：vewTpR1urY</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：vewTpR1urY</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/forms/{form_id}/fields")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string form_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【任务】批量删除关注人</para>
    /// <para>接口ID：7118952533649227779</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/batch_delete_follower</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于批量删除关注人。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/batch_delete_follower")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksByTaskIdBatchDeleteFollowerResponseDto>> PostTaskV1TasksByTaskIdBatchDeleteFollowerAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PostTaskV1TasksByTaskIdBatchDeleteFollowerBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】批量删除执行者</para>
    /// <para>接口ID：7118952533649244163</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/task-v1/task/batch_delete_collaborator</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于批量删除执行者。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务ID</para>
    /// <para>示例值：83912691-2e43-47fc-94a4-d512e03984fa</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v1/tasks/{task_id}/batch_delete_collaborator")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV1TasksByTaskIdBatchDeleteCollaboratorResponseDto>> PostTaskV1TasksByTaskIdBatchDeleteCollaboratorAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id,
        [JsonContent] Task.PostTaskV1TasksByTaskIdBatchDeleteCollaboratorBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】更新表单元数据</para>
    /// <para>接口ID：7119425455108669468</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新表单中的元数据项</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格文档 Token</para>
    /// <para>示例值：bascnv1jIEppJdTCn3jOosabcef</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 ID</para>
    /// <para>示例值：tblz8nadEUdxNMt5</para>
    /// </param>
    /// <param name="form_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表单 ID</para>
    /// <para>示例值：vew6oMbAa4</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/forms/{form_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto>> PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string form_id,
        [JsonContent] Base.PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdBodyDto dto);

    /// <summary>
    /// <para>【多维表格】获取表单元数据</para>
    /// <para>接口ID：7119425455108685852</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取表单的所有元数据项</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格文档 Token</para>
    /// <para>示例值：bascnv1jIEppJdTCn3jOosabcef</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格 ID</para>
    /// <para>示例值：tblz8nadEUdxNMt5</para>
    /// </param>
    /// <param name="form_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表单 ID</para>
    /// <para>示例值：vew6oMbAa4</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/forms/{form_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string form_id);

    /// <summary>
    /// <para>【云文档】修改电子表格属性</para>
    /// <para>接口ID：7120425077330903068</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于修改电子表格的属性。目前支持修改电子表格标题。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}")]
    System.Threading.Tasks.Task<FeishuResponse> PatchSheetsV3SpreadsheetsBySpreadsheetTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [JsonContent] Ccm.PatchSheetsV3SpreadsheetsBySpreadsheetTokenBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取电子表格信息</para>
    /// <para>接口ID：7120425077330919452</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据电子表格 token 获取电子表格的基础信息，包括电子表格的所有者、URL 链接等。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】查询工作表</para>
    /// <para>接口ID：7120425077330935836</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据工作表 ID 查询工作表属性信息，包括工作表的标题、索引位置、是否被隐藏等。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="sheet_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID。</para>
    /// <para>示例值：giDk9k</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/{sheet_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token,
        [PathQuery] string sheet_id);

    /// <summary>
    /// <para>【云文档】获取工作表</para>
    /// <para>接口ID：7120425077330952220</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据电子表格 token 获取表格中所有工作表及其属性信息，包括工作表 ID、标题、索引位置、是否被隐藏等。</para>
    /// </summary>
    /// <param name="spreadsheet_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>电子表格的 token。可通过以下两种方式获取。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)。</para>
    /// <para>- 电子表格的 URL：https://sample.feishu.cn/sheets/==Iow7sNNEphp3WbtnbCscPqabcef==</para>
    /// <para>- 调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)</para>
    /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/sheets/v3/spreadsheets/{spreadsheet_token}/sheets/query")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsQueryResponseDto>> GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsQueryAsync(
        UserAccessToken access_token,
        [PathQuery] string spreadsheet_token);

    /// <summary>
    /// <para>【云文档】获取协作者列表（新版本）</para>
    /// <para>接口ID：7121656165336367106</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据文件的 token 查询协作者。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="fields">
    /// <para>必填：否</para>
    /// <para>指定返回的协作者字段信息，如无指定则默认不返回</para>
    /// <para>**可选值有：**</para>
    /// <para>- `name`：协作者名</para>
    /// <para>- `type`：协作者类型</para>
    /// <para>- `avatar`：头像</para>
    /// <para>- `external_label`：外部标签</para>
    /// <para>**注意：**</para>
    /// <para>- 你可以使用特殊值`*`指定返回目前支持的所有字段</para>
    /// <para>- 你可以使用`,`分隔若干个你想指定返回的字段，如：`name,avatar`</para>
    /// <para>- 按需指定返回字段接口性能更好</para>
    /// <para>示例值：*</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/permissions/{token}/members")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1PermissionsByTokenMembersResponseDto>> GetDriveV1PermissionsByTokenMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type,
        [PathQuery] string? fields = null);

    /// <summary>
    /// <para>【云文档】批量获取评论</para>
    /// <para>接口ID：7123144042921590786</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/batch_query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据评论 ID 列表批量获取云文档评论信息，包括评论和回复 ID、回复的内容、评论人和回复人的用户 ID 等。支持返回全局评论以及局部评论（可通过 is_whole 字段区分）。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档 Token</para>
    /// <para>示例值：doxbcdl03Vsxhm7Qmnj110abcef</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>file：文件类型</item>
    /// <item>docx：新版文档类型</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/comments/batch_query")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesByFileTokenCommentsBatchQueryResponseDto>> PostDriveV1FilesByFileTokenCommentsBatchQueryAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [JsonContent] Ccm.PostDriveV1FilesByFileTokenCommentsBatchQueryBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取回复信息</para>
    /// <para>接口ID：7123144042921607170</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据评论 ID，获取该条评论对应的回复信息，包括回复 ID、回复内容、回复人的用户 ID 等。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档 Token</para>
    /// <para>示例值：doxbcdl03Vsxhm7Qmnj110abcef</para>
    /// </param>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>评论 ID</para>
    /// <para>示例值：1654857036541812356</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：1654857036541812356</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>file：文件夹类型</item>
    /// <item>docx：新版文档类型</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/comments/{comment_id}/replies")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto>> GetDriveV1FilesByFileTokenCommentsByCommentIdRepliesAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string comment_id,
        [PathQuery] string file_type,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】导出参会人明细</para>
    /// <para>接口ID：7124195547444477980</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/export/participant_list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>导出某个会议的参会人详情列表，具体权限要求请参考「资源介绍」。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/vc/v1/exports/participant_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PostVcV1ExportsParticipantListResponseDto>> PostVcV1ExportsParticipantListAsync(
        UserAccessToken access_token,
        [JsonContent] Vc.PostVcV1ExportsParticipantListBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】导出参会人会议质量数据</para>
    /// <para>接口ID：7124195547444494364</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/export/participant_quality_list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>导出某场会议某个参会人的音视频&amp;共享质量数据</para>
    /// <para>（仅支持已结束会议），具体权限要求请参考「资源介绍」。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/vc/v1/exports/participant_quality_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PostVcV1ExportsParticipantQualityListResponseDto>> PostVcV1ExportsParticipantQualityListAsync(
        UserAccessToken access_token,
        [JsonContent] Vc.PostVcV1ExportsParticipantQualityListBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】导出会议室预定数据</para>
    /// <para>接口ID：7124195547444510748</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/export/resource_reservation_list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>导出会议室预定数据，具体权限要求请参考「资源介绍」。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/vc/v1/exports/resource_reservation_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PostVcV1ExportsResourceReservationListResponseDto>> PostVcV1ExportsResourceReservationListAsync(
        UserAccessToken access_token,
        [JsonContent] Vc.PostVcV1ExportsResourceReservationListBodyDto dto);

    /// <summary>
    /// <para>【视频会议】查询导出任务结果</para>
    /// <para>接口ID：7124195547444527132</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/export/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查看异步导出的进度。</para>
    /// </summary>
    /// <param name="task_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务id</para>
    /// <para>示例值：7108646852144136212</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/exports/{task_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1ExportsByTaskIdResponseDto>> GetVcV1ExportsByTaskIdAsync(
        UserAccessToken access_token,
        [PathQuery] string task_id);

    /// <summary>
    /// <para>【视频会议】导出会议明细</para>
    /// <para>接口ID：7124235806021238785</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/export/meeting_list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>导出会议明细，具体权限要求请参考资源介绍。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/vc/v1/exports/meeting_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PostVcV1ExportsMeetingListResponseDto>> PostVcV1ExportsMeetingListAsync(
        UserAccessToken access_token,
        [JsonContent] Vc.PostVcV1ExportsMeetingListBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】列出仪表盘</para>
    /// <para>接口ID：7127206859065638914</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-dashboard/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 app_token，获取多维表格下的所有仪表盘</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格文档 Token</para>
    /// <para>示例值：bascng7vrxcxpig7geggXiCtadY</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：blknkqrP3RqUkcAW</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/dashboards")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenDashboardsResponseDto>> GetBitableV1AppsByAppTokenDashboardsAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【日历】取消订阅日历变更事件</para>
    /// <para>接口ID：7129706575502098436</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/unsubscription</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口为当前用户身份取消订阅[日历变更事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/events/changed)。</para>
    /// </summary>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/unsubscription")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsUnsubscriptionAsync(
        UserAccessToken access_token);

    /// <summary>
    /// <para>【日历】取消订阅日历访问控制变更事件</para>
    /// <para>接口ID：7129706575502114820</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-acl/unsubscription</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口以用户身份取消订阅指定日历下的访问控制变更事件。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历ID。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/acls/unsubscription")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdAclsUnsubscriptionAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【日历】取消订阅日程变更事件</para>
    /// <para>接口ID：7129706575502131204</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/unsubscription</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>调用该接口以用户身份取消订阅指定日历下的日程变更事件。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/unsubscription")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdEventsUnsubscriptionAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id);

    /// <summary>
    /// <para>【词典】上传图片</para>
    /// <para>接口ID：7138031713099317252</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/file/upload</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>词条图片资源上传。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>二进制文件内容，高宽像素在 320-4096 像素之间，大小在 3KB-10MB 的图片</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/files/upload")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1FilesUploadResponseDto>> PostBaikeV1FilesUploadAsync(
        UserAccessToken access_token,
        [FormDataContent] Baike.PostBaikeV1FilesUploadBodyDto dto,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【词典】下载图片</para>
    /// <para>接口ID：7138031713099333636</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/file/download</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过 file_token 下载原图片。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要下载的文件 token</para>
    /// <para>示例值：boxbcEcmKiD3***vgqWTpvdc7jc</para>
    /// </param>
    /// <returns>返回文件二进制流</returns>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/baike/v1/files/{file_token}/download")]
    System.Threading.Tasks.Task<HttpResponseMessage> GetBaikeV1FilesByFileTokenDownloadAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token);

    /// <summary>
    /// <para>【消息与群组】Pin 消息</para>
    /// <para>接口ID：7138313270488858626</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/pin/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>Pin 一条指定的消息。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/pins")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1PinsResponseDto>> PostImV1PinsAsync(
        UserAccessToken access_token,
        [JsonContent] Im.PostImV1PinsBodyDto dto);

    /// <summary>
    /// <para>【消息与群组】移除 Pin 消息</para>
    /// <para>接口ID：7138313270488875010</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/pin/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>移除一条指定消息的 Pin。</para>
    /// </summary>
    /// <param name="message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待移除Pin的消息ID，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/im/v1/pins/{message_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteImV1PinsByMessageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string message_id);

    /// <summary>
    /// <para>【消息与群组】获取群内 Pin 消息</para>
    /// <para>接口ID：7138313270488891394</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/pin/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取所在群内指定时间范围内的所有 Pin 消息。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>必填：是</para>
    /// <para>待获取Pin消息的Chat ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>示例值：oc_234jsi43d3ssi993d43545f</para>
    /// </param>
    /// <param name="start_time">
    /// <para>必填：否</para>
    /// <para>Pin信息的起始时间（毫秒级时间戳）。若未填写默认获取到群聊内最早的Pin信息</para>
    /// <para>示例值：1658632251800</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：否</para>
    /// <para>Pin信息的结束时间（毫秒级时间戳）。若未填写默认从群聊内最新的Pin信息开始获取</para>
    /// <para>**注意**：`end_time`值应大于`start_time`值</para>
    /// <para>示例值：1658731646425</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>此次调用中使用的分页的大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：GxmvlNRvP0NdQZpa7yIqf_Lv_QuBwTQ8tXkX7w-irAghVD_TvuYd1aoJ1LQph86O-XImC4X9j9FhUPhXQDvtrQ==</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/im/v1/pins")]
    System.Threading.Tasks.Task<FeishuResponse<Im.GetImV1PinsResponseDto>> GetImV1PinsAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [PathQuery] string? start_time = null,
        [PathQuery] string? end_time = null,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【消息与群组】获取群分享链接</para>
    /// <para>接口ID：7139929321426386972</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/link</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定群的分享链接。</para>
    /// </summary>
    /// <param name="chat_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>待获取分享链接的群ID，详情参见[群ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</para>
    /// <para>**注意**：单聊、密聊、团队群不支持分享群链接</para>
    /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/im/v1/chats/{chat_id}/link")]
    System.Threading.Tasks.Task<FeishuResponse<Im.PostImV1ChatsByChatIdLinkResponseDto>> PostImV1ChatsByChatIdLinkAsync(
        UserAccessToken access_token,
        [PathQuery] string chat_id,
        [JsonContent] Im.PostImV1ChatsByChatIdLinkBodyDto dto);

    /// <summary>
    /// <para>【视频会议】下载导出文件</para>
    /// <para>接口ID：7143809848869109763</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/export/download</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>下载导出文件。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：6yHu7Igp7Igy62Ez6fLr6IJz7j9i5WMe6fHq5yZeY2Jz6yLqYAMAY46fZfEz64Lr5fYyYQ==</para>
    /// </param>
    /// <returns>返回文件二进制流</returns>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/exports/download")]
    System.Threading.Tasks.Task<HttpResponseMessage> GetVcV1ExportsDownloadAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token);

    /// <summary>
    /// <para>【云文档】获取文档版本列表</para>
    /// <para>接口ID：7156062028484984836</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-version/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取文档所有版本。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>源文档token，如何获取文档Token可以参考[如何获取云文档相关token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doxbcyvqZlSc9WlHvQMlSJwUrsb</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：是</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：1665739388</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="obj_type">
    /// <para>必填：是</para>
    /// <para>原文档类型</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/versions")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenVersionsResponseDto>> GetDriveV1FilesByFileTokenVersionsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string obj_type,
        [PathQuery] int page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】获取文档版本</para>
    /// <para>接口ID：7156062028485001220</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-version/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取文档版本。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>源文档token</para>
    /// <para>示例值：shtbcqqoXZJaKYrfN5IHQg4sVFZ</para>
    /// </param>
    /// <param name="version_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>版本文档版本号</para>
    /// <para>示例值：file_version</para>
    /// </param>
    /// <param name="obj_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/versions/{version_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenVersionsByVersionIdResponseDto>> GetDriveV1FilesByFileTokenVersionsByVersionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string version_id,
        [PathQuery] string obj_type,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】删除文档版本</para>
    /// <para>接口ID：7156062028485017604</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-version/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除文档版本。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>版本文档token，如何获取文档Token可以参考[如何获取云文档相关token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doxbcyvqZlSc9WlHvQMlSJwUrsb</para>
    /// </param>
    /// <param name="version_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>版本文档版本号</para>
    /// <para>示例值：file_version</para>
    /// </param>
    /// <param name="obj_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// </list>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/drive/v1/files/{file_token}/versions/{version_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteDriveV1FilesByFileTokenVersionsByVersionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string version_id,
        [PathQuery] string obj_type,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【云文档】创建文档版本</para>
    /// <para>接口ID：7156062028485033988</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-version/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建文档版本。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>源文档token，如何获取文档Token可以参考[如何获取云文档相关token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doxbcyvqZlSc9WlHvQMlSJwUrsb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/{file_token}/versions")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesByFileTokenVersionsResponseDto>> PostDriveV1FilesByFileTokenVersionsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [JsonContent] Ccm.PostDriveV1FilesByFileTokenVersionsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】提取潜在的词条</para>
    /// <para>接口ID：7158733167621242883</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/baike-v1/entity/extract</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>提取文本中可能成为词条的词语，且不会过滤已经成为词条的词语。同时返回推荐的别名。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/baike/v1/entities/extract")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostBaikeV1EntitiesExtractResponseDto>> PostBaikeV1EntitiesExtractAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostBaikeV1EntitiesExtractBodyDto dto);

    /// <summary>
    /// <para>【视频会议】搜索会议室</para>
    /// <para>接口ID：7160517357591937027</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/search</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该接口可以用来搜索会议室，支持使用关键词进行搜索，也支持使用自定义会议室 ID 进行查询。该接口只会返回用户有预定权限的会议室列表。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/vc/v1/rooms/search")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.PostVcV1RoomsSearchResponseDto>> PostVcV1RoomsSearchAsync(
        UserAccessToken access_token,
        [JsonContent] Vc.PostVcV1RoomsSearchBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】复制仪表盘</para>
    /// <para>接口ID：7177650713441812483</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-dashboard/copy</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据现有仪表盘复制出新的仪表盘</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格 token</para>
    /// <para>示例值：basbcldP5xZeskcHDFZQfeToydb</para>
    /// </param>
    /// <param name="block_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格 block_id</para>
    /// <para>示例值：blkEsvEEaNllY2UV</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/dashboards/{block_id}/copy")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyResponseDto>> PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string block_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyBodyDto dto);

    /// <summary>
    /// <para>【多维表格】更新视图</para>
    /// <para>接口ID：7177650713441828867</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-view/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于增量修改视图信息</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：bascng7vrxcxpig7geggXiCtadY</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>视图 ID</para>
    /// <para>示例值：vewTpR1urY</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/views/{view_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto>> PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string view_id,
        [JsonContent] Base.PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdBodyDto dto);

    /// <summary>
    /// <para>【多维表格】检索视图</para>
    /// <para>接口ID：7177650713441845251</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-view/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口根据 view_id 检索现有视图</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>base app token</para>
    /// <para>示例值：bascnCMII2ORej2RItqpZZUNMIe</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>table id</para>
    /// <para>示例值：tblsRc9GRRXKqhvW</para>
    /// </param>
    /// <param name="view_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>视图 ID</para>
    /// <para>示例值：vewTpR1urY</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/views/{view_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.GetBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto>> GetBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [PathQuery] string view_id);

    /// <summary>
    /// <para>【身份验证】获取登录用户信息</para>
    /// <para>接口ID：7180265937329537028</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/authen-v1/user_info/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>通过 `user_access_token` 获取登录用户的信息。</para>
    /// </summary>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/authen/v1/user_info")]
    System.Threading.Tasks.Task<FeishuResponse<Auth.GetAuthenV1UserInfoResponseDto>> GetAuthenV1UserInfoAsync(
        UserAccessToken access_token);

    /// <summary>
    /// <para>【妙记】获取妙记统计数据</para>
    /// <para>接口ID：7181729161035612161</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute-statistics/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过这个接口，可以获得妙记的访问情况统计，包含PV、UV、访问过的 user id、访问过的 user timestamp。</para>
    /// </summary>
    /// <param name="minute_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>妙记唯一标识。可从妙记链接中获取，一般为链接中最后一串字符</para>
    /// <para>示例值：obcnq3b9jl72l83w4f14xxxx</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/minutes/v1/minutes/{minute_token}/statistics")]
    System.Threading.Tasks.Task<FeishuResponse<Minutes.GetMinutesV1MinutesByMinuteTokenStatisticsResponseDto>> GetMinutesV1MinutesByMinuteTokenStatisticsAsync(
        UserAccessToken access_token,
        [PathQuery] string minute_token,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【妙记】获取妙记信息</para>
    /// <para>接口ID：7181729161035628545</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过这个接口，可以得到一篇妙记的基础概述信息，包含 `owner_id`、`create_time`、标题、封面、时长和 URL。</para>
    /// </summary>
    /// <param name="minute_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>妙记唯一标识。可从妙记链接中获取，一般为链接中最后一串字符</para>
    /// <para>示例值：obcnq3b9jl72l83w4f14xxxx</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/minutes/v1/minutes/{minute_token}")]
    System.Threading.Tasks.Task<FeishuResponse<Minutes.GetMinutesV1MinutesByMinuteTokenResponseDto>> GetMinutesV1MinutesByMinuteTokenAsync(
        UserAccessToken access_token,
        [PathQuery] string minute_token,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】更新数据表</para>
    /// <para>接口ID：7182466310810402817</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于更新数据表的基本信息，包括数据表的名称等。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格的唯一标识符 [app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：XrgTb4y1haKYnasu0xXb1g7lcSg</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>多维表格数据表的唯一标识符 [table_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>示例值：tbl1TkhyTWDkSoZ3</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PatchBitableV1AppsByAppTokenTablesByTableIdResponseDto>> PatchBitableV1AppsByAppTokenTablesByTableIdAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto dto);

    /// <summary>
    /// <para>【云文档】转移所有者</para>
    /// <para>接口ID：7186547801970507777</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/transfer_owner</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据云文档 token 和用户信息转移文件的所有者。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="need_notification">
    /// <para>必填：否</para>
    /// <para>是否需要通知新的文件所有者</para>
    /// <para>示例值：true</para>
    /// <para>默认值：true</para>
    /// </param>
    /// <param name="remove_old_owner">
    /// <para>必填：否</para>
    /// <para>转移后是否需要移除原文件所有者的权限</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </param>
    /// <param name="stay_put">
    /// <para>必填：否</para>
    /// <para>仅当文件在个人文件夹下，此参数才会生效。如果设为`false`，系统会将该内容移至新所有者的空间下。如果设为`true`，则留在原位置。</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </param>
    /// <param name="old_owner_perm">
    /// <para>必填：否</para>
    /// <para>仅当 remove_old_owner = false 时，此参数才会生效 保留原文件所有者指定的权限角色</para>
    /// <para>示例值：view</para>
    /// <para>默认值：full_access</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/permissions/{token}/members/transfer_owner")]
    System.Threading.Tasks.Task<FeishuResponse> PostDriveV1PermissionsByTokenMembersTransferOwnerAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type,
        [JsonContent] Ccm.PostDriveV1PermissionsByTokenMembersTransferOwnerBodyDto dto,
        [PathQuery] bool? need_notification = true,
        [PathQuery] bool? remove_old_owner = false,
        [PathQuery] bool? stay_put = false,
        [PathQuery] string? old_owner_perm = "full_access");

    /// <summary>
    /// <para>【云文档】判断当前用户是否有某权限</para>
    /// <para>接口ID：7186547801970524161</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/auth</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 判断当前登录用户是否具有某权限。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="action">
    /// <para>必填：是</para>
    /// <para>需要判断的权限</para>
    /// <para>示例值：view</para>
    /// <list type="bullet">
    /// <item>view：阅读</item>
    /// <item>edit：编辑</item>
    /// <item>share：分享</item>
    /// <item>comment：评论</item>
    /// <item>export：导出</item>
    /// <item>copy：拷贝</item>
    /// <item>print：打印</item>
    /// <item>manage_public：管理权限设置</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/permissions/{token}/members/auth")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1PermissionsByTokenMembersAuthResponseDto>> GetDriveV1PermissionsByTokenMembersAuthAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type,
        [PathQuery] string action);

    /// <summary>
    /// <para>【视频会议】查询会议明细</para>
    /// <para>接口ID：7194805625628033027</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting_list/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询会议明细，具体权限要求请参考[资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting-room-data/resource-introduction)</para>
    /// </summary>
    /// <param name="start_time">
    /// <para>必填：是</para>
    /// <para>查询开始时间（unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：是</para>
    /// <para>查询结束时间（unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="meeting_status">
    /// <para>必填：否</para>
    /// <para>会议状态（不传默认为已结束会议）</para>
    /// <para>示例值：2</para>
    /// <list type="bullet">
    /// <item>1：进行中</item>
    /// <item>2：已结束</item>
    /// <item>3：待召开。该枚举值只读，请求时不支持选择。</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="meeting_no">
    /// <para>必填：否</para>
    /// <para>按9位会议号筛选（最多一个筛选条件）</para>
    /// <para>示例值：123456789</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id">
    /// <para>必填：否</para>
    /// <para>按参会Lark用户筛选（最多一个筛选条件）</para>
    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="room_id">
    /// <para>必填：否</para>
    /// <para>按参会Rooms筛选（最多一个筛选条件）</para>
    /// <para>示例值：omm_eada1d61a550955240c28757e7dec3af</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="meeting_type">
    /// <para>必填：否</para>
    /// <para>按会议类型筛选（最多一个筛选条件）</para>
    /// <para>示例值：2</para>
    /// <list type="bullet">
    /// <item>1：全部类型（默认）</item>
    /// <item>2：视频会议</item>
    /// <item>3：本地投屏</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页尺寸大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：20</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/meeting_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1MeetingListResponseDto>> GetVcV1MeetingListAsync(
        UserAccessToken access_token,
        [PathQuery] string start_time,
        [PathQuery] string end_time,
        [PathQuery] int? meeting_status = null,
        [PathQuery] string? meeting_no = null,
        [PathQuery] string? user_id = null,
        [PathQuery] string? room_id = null,
        [PathQuery] int? meeting_type = null,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】查询参会人会议质量数据</para>
    /// <para>接口ID：7194805625628049411</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/participant_quality_list/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询参会人会议质量数据（仅支持已结束会议），具体权限要求请参考「资源介绍」。</para>
    /// </summary>
    /// <param name="meeting_start_time">
    /// <para>必填：是</para>
    /// <para>会议开始时间（需要精确到一分钟，unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="meeting_end_time">
    /// <para>必填：是</para>
    /// <para>会议结束时间（unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="meeting_no">
    /// <para>必填：是</para>
    /// <para>9位会议号</para>
    /// <para>示例值：123456789</para>
    /// </param>
    /// <param name="join_time">
    /// <para>必填：是</para>
    /// <para>参会人入会时间（unix时间，单位sec），可从「查询参会人明细」返回结果获取</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="user_id">
    /// <para>必填：否</para>
    /// <para>参会人为Lark用户时填入，room_id和user_id必须只填一个</para>
    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="room_id">
    /// <para>必填：否</para>
    /// <para>参会人为Rooms时填入，room_id和user_id必须只填一个</para>
    /// <para>示例值：omm_eada1d61a550955240c28757e7dec3af</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页尺寸大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：20</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/participant_quality_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1ParticipantQualityListResponseDto>> GetVcV1ParticipantQualityListAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_start_time,
        [PathQuery] string meeting_end_time,
        [PathQuery] string meeting_no,
        [PathQuery] string join_time,
        [PathQuery] string? user_id = null,
        [PathQuery] string? room_id = null,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【视频会议】查询会议室预定数据</para>
    /// <para>接口ID：7194805625628065795</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/resource_reservation_list/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询会议室预定数据，，具体权限要求请参考「资源介绍」。</para>
    /// </summary>
    /// <param name="room_level_id">
    /// <para>必填：是</para>
    /// <para>层级ID，如传递非omb前缀的异常ID时，会默认使用租户层级进行兜底</para>
    /// <para>示例值：omb_57c9cc7d9a81e27e54c8fabfd02759e7</para>
    /// </param>
    /// <param name="need_topic">
    /// <para>必填：否</para>
    /// <para>是否展示会议主题</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="start_time">
    /// <para>必填：是</para>
    /// <para>查询开始时间（unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：是</para>
    /// <para>查询结束时间（unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="room_ids">
    /// <para>必填：是</para>
    /// <para>待筛选的会议室id列表</para>
    /// <para>示例值：["omm_12443435556"]</para>
    /// </param>
    /// <param name="is_exclude">
    /// <para>必填：否</para>
    /// <para>默认为false；若为false，则获取room_ids字段传入的会议室列表预定数据；若为true，则根据room_level_id字段获取层级下的会议室列表，并过滤掉room_ids范围的会议室，获取剩余会议室的预定数据</para>
    /// <para>示例值：false</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页尺寸大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：20</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/resource_reservation_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1ResourceReservationListResponseDto>> GetVcV1ResourceReservationListAsync(
        UserAccessToken access_token,
        [PathQuery] string room_level_id,
        [PathQuery] string start_time,
        [PathQuery] string end_time,
        [PathQuery] string[] room_ids,
        [PathQuery] bool? need_topic = null,
        [PathQuery] bool? is_exclude = null,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【视频会议】查询参会人明细</para>
    /// <para>接口ID：7194805625628147715</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/participant_list/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>查询参会人明细，具体权限要求请参考[资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting-room-data/resource-introduction)</para>
    /// </summary>
    /// <param name="meeting_start_time">
    /// <para>必填：是</para>
    /// <para>会议开始时间（unix时间，单位sec）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="meeting_end_time">
    /// <para>必填：是</para>
    /// <para>会议结束时间（unix时间，单位sec，若是进行中会议可填当前时间，否则填准确的会议结束时间）</para>
    /// <para>示例值：1655276858</para>
    /// </param>
    /// <param name="meeting_status">
    /// <para>必填：否</para>
    /// <para>会议状态（不传默认为已结束会议）</para>
    /// <para>示例值：2</para>
    /// <list type="bullet">
    /// <item>1：进行中</item>
    /// <item>2：已结束</item>
    /// <item>3：待召开</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="meeting_no">
    /// <para>必填：是</para>
    /// <para>9位会议号</para>
    /// <para>示例值：123456789</para>
    /// </param>
    /// <param name="user_id">
    /// <para>必填：否</para>
    /// <para>按参会Lark用户筛选（最多一个筛选条件）</para>
    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="room_id">
    /// <para>必填：否</para>
    /// <para>按参会Rooms筛选（最多一个筛选条件）</para>
    /// <para>示例值：omm_eada1d61a550955240c28757e7dec3af</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页尺寸大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：20</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/vc/v1/participant_list")]
    System.Threading.Tasks.Task<FeishuResponse<Vc.GetVcV1ParticipantListResponseDto>> GetVcV1ParticipantListAsync(
        UserAccessToken access_token,
        [PathQuery] string meeting_start_time,
        [PathQuery] string meeting_end_time,
        [PathQuery] string meeting_no,
        [PathQuery] int? meeting_status = null,
        [PathQuery] string? user_id = null,
        [PathQuery] string? room_id = null,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【多维表格】复制多维表格</para>
    /// <para>接口ID：7205776220394160156</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/copy</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>复制一个多维表格，可以指定复制到某个有权限的文件夹下</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>[多维表格 App token](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
    /// <para>示例值：S404b*****e9PQsYDWYcNryFn0g</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/copy")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenCopyResponseDto>> PostBitableV1AppsByAppTokenCopyAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [JsonContent] Base.PostBitableV1AppsByAppTokenCopyBodyDto dto);

    /// <summary>
    /// <para>【搜索】搜索消息</para>
    /// <para>接口ID：7208771563588059139</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/message/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>用户可以通过关键字搜索可见消息，可见性和套件内搜索一致。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：9e91187f9107ef4d43cd71c3722cd97665e6cec51bf30a06328839bc9867</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/search/v2/message")]
    System.Threading.Tasks.Task<FeishuResponse<Search.PostSearchV2MessageResponseDto>> PostSearchV2MessageAsync(
        UserAccessToken access_token,
        [JsonContent] Search.PostSearchV2MessageBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【搜索】搜索应用</para>
    /// <para>接口ID：7208771563588075523</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/app/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>用户可以通过关键字搜索到可见应用，应用可见性与套件内搜索一致。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：9e91187f9107ef4d43cd71c3722cd97665e6cec51bf30a06328839bc9867</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/search/v2/app")]
    System.Threading.Tasks.Task<FeishuResponse<Search.PostSearchV2AppResponseDto>> PostSearchV2AppAsync(
        UserAccessToken access_token,
        [JsonContent] Search.PostSearchV2AppBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【云文档】创建文件快捷方式</para>
    /// <para>接口ID：7216001760515112961</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/create_shortcut</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建指定文件的快捷方式到云空间的其它文件夹中。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/files/create_shortcut")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1FilesCreateShortcutResponseDto>> PostDriveV1FilesCreateShortcutAsync(
        UserAccessToken access_token,
        [JsonContent] Ccm.PostDriveV1FilesCreateShortcutBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【应用信息】获取用户自定义常用的应用</para>
    /// <para>接口ID：7218970579747110913</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v5/application/favourite</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>获取用户自定义常用的应用。</para>
    /// </summary>
    /// <param name="language">
    /// <para>必填：否</para>
    /// <para>应用信息的语言版本</para>
    /// <para>**示例值**："zh_cn"</para>
    /// <para>**可选值有**：</para>
    /// <para>zh_cn:中文,en_us:英文,ja_jp:日文</para>
    /// <list type="bullet">
    /// <item>zh_cn：中文</item>
    /// <item>en_us：英文</item>
    /// <item>ja_jp：日文</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>**示例值**："new-e11ee058b4a8ed2881da11ac7e37c4fc"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>**示例值**：10</para>
    /// <para>**默认值**：`10`</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/application/v5/applications/favourite")]
    System.Threading.Tasks.Task<FeishuResponse<Application.Spec.GetApplicationV5ApplicationsFavouriteResponseDto>> GetApplicationV5ApplicationsFavouriteAsync(
        UserAccessToken access_token,
        [PathQuery] string? language = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 10);

    /// <summary>
    /// <para>【应用信息】获取管理员推荐的应用</para>
    /// <para>接口ID：7218970579747127297</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v5/application/recommend</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>获取管理员推荐的应用。</para>
    /// </summary>
    /// <param name="language">
    /// <para>必填：否</para>
    /// <para>应用信息的语言版本</para>
    /// <para>**示例值**："zh_cn"</para>
    /// <para>**可选值有**：</para>
    /// <para>zh_cn:中文,en_us:英文,ja_jp:日文</para>
    /// <list type="bullet">
    /// <item>zh_cn：中文</item>
    /// <item>en_us：英文</item>
    /// <item>ja_jp：日文</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="recommend_type">
    /// <para>必填：否</para>
    /// <para>推荐应用类型，默认为用户不可移除的推荐应用列表</para>
    /// <para>**示例值**："user_unremovable"</para>
    /// <para>**可选值有**：</para>
    /// <para>user_unremovable:用户不可移除的推荐应用列表,user_removable:用户可移除的推荐应用列表</para>
    /// <para>**默认值**：`user_unremovable`</para>
    /// <list type="bullet">
    /// <item>user_unremovable：用户不可移除的推荐应用列表</item>
    /// <item>user_removable：用户可移除的推荐应用列表</item>
    /// </list>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>**示例值**："new-e11ee058b4a8ed2881da11ac7e37c4fc"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>**示例值**：10</para>
    /// <para>**默认值**：`10`</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/application/v5/applications/recommend")]
    System.Threading.Tasks.Task<FeishuResponse<Application.Spec.GetApplicationV5ApplicationsRecommendResponseDto>> GetApplicationV5ApplicationsRecommendAsync(
        UserAccessToken access_token,
        [PathQuery] string? language = null,
        [PathQuery] string? recommend_type = null,
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 10);

    /// <summary>
    /// <para>【云文档】开启密码</para>
    /// <para>接口ID：7220305453616152580</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-public-password/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 开启云文档的密码。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙计（暂不支持）</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/drive/v1/permissions/{token}/public/password")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PostDriveV1PermissionsByTokenPublicPasswordResponseDto>> PostDriveV1PermissionsByTokenPublicPasswordAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type);

    /// <summary>
    /// <para>【云文档】刷新密码</para>
    /// <para>接口ID：7220305453616168964</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-public-password/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 刷新云文档的密码。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙计（暂不支持）</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/drive/v1/permissions/{token}/public/password")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PutDriveV1PermissionsByTokenPublicPasswordResponseDto>> PutDriveV1PermissionsByTokenPublicPasswordAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type);

    /// <summary>
    /// <para>【云文档】关闭密码</para>
    /// <para>接口ID：7220305453616185348</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-public-password/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 关闭云文档的密码。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙计（暂不支持）</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/drive/v1/permissions/{token}/public/password")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteDriveV1PermissionsByTokenPublicPasswordAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type);

    /// <summary>
    /// <para>【云文档】获取云文档权限设置</para>
    /// <para>接口ID：7224057619119112196</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uIzNzUjLyczM14iM3MTN/drive-v2/permission-public/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 获取云文档的权限设置。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v2/permissions/{token}/public")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV2PermissionsByTokenPublicResponseDto>> GetDriveV2PermissionsByTokenPublicAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type);

    /// <summary>
    /// <para>【云文档】更新云文档权限设置</para>
    /// <para>接口ID：7224057619119128580</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uIzNzUjLyczM14iM3MTN/drive-v2/permission-public/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于根据 filetoken 更新云文档的权限设置。</para>
    /// </summary>
    /// <param name="token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件的 token，获取方式见 [如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>示例值：doccnBKgoMyY5OMbUG6FioTXuBe</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：是</para>
    /// <para>文件类型，需要与文件的 token 相匹配</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>file：云空间文件</item>
    /// <item>wiki：知识库节点</item>
    /// <item>bitable：多维表格</item>
    /// <item>docx：新版文档</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>minutes：妙记</item>
    /// <item>slides：幻灯片</item>
    /// </list>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/drive/v2/permissions/{token}/public")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.PatchDriveV2PermissionsByTokenPublicResponseDto>> PatchDriveV2PermissionsByTokenPublicAsync(
        UserAccessToken access_token,
        [PathQuery] string token,
        [PathQuery] string type,
        [JsonContent] Ccm.PatchDriveV2PermissionsByTokenPublicBodyDto dto);

    /// <summary>
    /// <para>【云文档】获取文件访问记录</para>
    /// <para>接口ID：7232207479622074371</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-view_record/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取文档、电子表格、多维表格等文件的历史访问记录，包括访问者的 ID、姓名、头像和最近访问时间。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文件 token。获取方式参考[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)。</para>
    /// <para>示例值：XIHSdYSI7oMEU1xrsnxc8fabcef</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：是</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：1674037112--7189934631754563585</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文件类型</para>
    /// <para>示例值：docx</para>
    /// <list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>mindnote：思维笔记</item>
    /// <item>wiki：知识库文档</item>
    /// <item>file：文件</item>
    /// </list>
    /// </param>
    /// <param name="viewer_id_type">
    /// <para>必填：否</para>
    /// <para>返回的访问者 ID 的类型。</para>
    /// <para>**当值为`user_id`时，字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee_id:readonly" desc="获取用户 user ID" support_app_types="custom" tags=""&gt;获取用户 user ID&lt;/md-perm&gt;</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/view_records")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenViewRecordsResponseDto>> GetDriveV1FilesByFileTokenViewRecordsAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [PathQuery] int page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? viewer_id_type = "open_id");

    /// <summary>
    /// <para>【通讯录】批量获取用户信息</para>
    /// <para>接口ID：7243624444425502748</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/batch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于批量获取通讯录用户的信息。</para>
    /// </summary>
    /// <param name="user_ids">
    /// <para>必填：是</para>
    /// <para>用户ID，类型需要与查询参数中的user_id_type保持一致。</para>
    /// <para>例如user_id_type=open_id，user_id的类型需为open_id</para>
    /// <para>不同ID的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>如需一次查询多个用户ID，可通过将同一参数名多次传递，并且每次传递不同的参数值。例如：</para>
    /// <para>`https://{url}?user_ids={user_id1}&amp;user_ids={user_id2}`。单次最大请求ID数量为50。</para>
    /// <para>其中：</para>
    /// <para>* `user_ids`是参数名，可以多次传递</para>
    /// <para>* `user_id1`和`user_id2`是参数值</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>指定查询结果中用户关联的部门ID类型</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>open_department_id：以open_department_id来标识部门</item>
    /// <item>department_id：以自定义department_id来标识部门</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/users/batch")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3UsersBatchResponseDto>> GetContactV3UsersBatchAsync(
        UserAccessToken access_token,
        [PathQuery] string[] user_ids,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? department_id_type = "open_department_id");

    /// <summary>
    /// <para>【通讯录】批量获取部门信息</para>
    /// <para>接口ID：7243624444425519132</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/batch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于从通讯录批量获取部门信息。</para>
    /// </summary>
    /// <param name="department_ids">
    /// <para>必填：是</para>
    /// <para>查询的部门ID列表，类型需要与department_id_type对应。</para>
    /// <para>不同 ID 的说明及获取方式 参见[部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>如需一次查询多个部门ID，可通过将同一参数名多次传递，并且每次传递不同的参数值。例如：</para>
    /// <para>`https://{url}?department_ids={department_id1}&amp;department_ids={department_id2}`。单次最大请求ID数量为50。</para>
    /// <para>其中：</para>
    /// <para>* department_ids是参数名，可以多次传递</para>
    /// <para>* department_id1和department_id2是参数值</para>
    /// </param>
    /// <param name="department_id_type">
    /// <para>必填：否</para>
    /// <para>说明请求中department_ids参数所使用的部门ID类型</para>
    /// <para>不同 ID 的说明 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>示例值：open_department_id</para>
    /// <list type="bullet">
    /// <item>open_department_id：用来在具体某个应用中标识一个部门，同一个部门 在不同应用中的 open_department_id 相同。</item>
    /// <item>department_id：用来标识租户内一个唯一的部门</item>
    /// </list>
    /// <para>默认值：open_department_id</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/departments/batch")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3DepartmentsBatchResponseDto>> GetContactV3DepartmentsBatchAsync(
        UserAccessToken access_token,
        [PathQuery] string[] department_ids,
        [PathQuery] string? department_id_type = "open_department_id",
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】获取词条详情</para>
    /// <para>接口ID：7249689905696981020</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过词条 id 拉取对应的词条详情信息。</para>
    /// </summary>
    /// <param name="entity_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>词条 ID</para>
    /// <para>示例值：enterprise_515879</para>
    /// </param>
    /// <param name="provider">
    /// <para>必填：否</para>
    /// <para>外部系统</para>
    /// <para>示例值：星云</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="outer_id">
    /// <para>必填：否</para>
    /// <para>词条在外部系统中对应的唯一 ID</para>
    /// <para>示例值：123aaa</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/lingo/v1/entities/{entity_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetLingoV1EntitiesByEntityIdResponseDto>> GetLingoV1EntitiesByEntityIdAsync(
        UserAccessToken access_token,
        [PathQuery] string entity_id,
        [PathQuery] string? provider = null,
        [PathQuery] string? outer_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】获取词条列表</para>
    /// <para>接口ID：7249689905696997404</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>分页拉取词条列表数据，支持拉取租户内(或指定词库内)的全部词条。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：408ecac018b2e3518db37275e812aad7bb8ad3e755fc886f322ac6c430ba</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="provider">
    /// <para>必填：否</para>
    /// <para>相关外部系统【可用来过滤词条数据】</para>
    /// <para>示例值：星云</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="repo_id">
    /// <para>必填：否</para>
    /// <para>词库 id(不传时默认返回全员词库数据)</para>
    /// <para>如以应用身份拉取非全员词库的词条，需要在“词库设置”页面添加应用；若以用户身份拉取非全员词库的词条，该用户需要拥有对应词库的可见权限。</para>
    /// <para>示例值：7152790921053274113</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/lingo/v1/entities")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetLingoV1EntitiesResponseDto>> GetLingoV1EntitiesAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? provider = null,
        [PathQuery] string? repo_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】上传图片</para>
    /// <para>接口ID：7249689905697013788</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/file/upload</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>词条图片资源上传。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>二进制文件内容，高宽像素在 320-4096 像素之间，大小在 3KB-10MB 的图片</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/lingo/v1/files/upload")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostLingoV1FilesUploadResponseDto>> PostLingoV1FilesUploadAsync(
        UserAccessToken access_token,
        [FormDataContent] Baike.PostLingoV1FilesUploadBodyDto dto,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【词典】下载图片</para>
    /// <para>接口ID：7249689905697030172</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/file/download</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>通过 file_token 下载原图片。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要下载的文件 token</para>
    /// <para>示例值：boxbcEcmKiD3***vgqWTpvdc7jc</para>
    /// </param>
    /// <returns>返回文件二进制流</returns>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/lingo/v1/files/{file_token}/download")]
    System.Threading.Tasks.Task<HttpResponseMessage> GetLingoV1FilesByFileTokenDownloadAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token);

    /// <summary>
    /// <para>【词典】创建草稿</para>
    /// <para>接口ID：7249689905697046556</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/draft/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>草稿并非词条，而是指通过 API 发起创建新词条或更新现有词条的申请。</para>
    /// <para>词典管理员审核通过后，草稿将变为新的词条或覆盖已有词条。</para>
    /// </summary>
    /// <param name="repo_id">
    /// <para>必填：否</para>
    /// <para>词库ID（需要在指定词库创建草稿时填写，不填写默认创建至全员词库）</para>
    /// <para>如以应用身份创建草稿到非全员词库，需要在“词库设置”页面添加应用；若以用户身份创建草稿到非全员词库，该用户需要拥有对应词库的可见权限。</para>
    /// <para>示例值：72025****640276</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/lingo/v1/drafts")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostLingoV1DraftsResponseDto>> PostLingoV1DraftsAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostLingoV1DraftsBodyDto dto,
        [PathQuery] string? repo_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】更新草稿</para>
    /// <para>接口ID：7249689905697062940</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/draft/update</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据 draft_id 更新草稿内容，已审批的草稿无法编辑。</para>
    /// </summary>
    /// <param name="draft_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>草稿ID</para>
    /// <para>示例值：7241543272228814852</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/lingo/v1/drafts/{draft_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PutLingoV1DraftsByDraftIdResponseDto>> PutLingoV1DraftsByDraftIdAsync(
        UserAccessToken access_token,
        [PathQuery] string draft_id,
        [JsonContent] Baike.PutLingoV1DraftsByDraftIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】精准搜索词条</para>
    /// <para>接口ID：7249689905697079324</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/match</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将关键词与词条名、别名精准匹配，并返回对应的 词条 ID。</para>
    /// </summary>
    /// <param name="repo_id">
    /// <para>必填：否</para>
    /// <para>词库ID(不传时默认在全员词库内搜索)</para>
    /// <para>如以应用身份搜索非全员词库中的词条，需要在“词库设置”页面添加应用；若以用户身份搜索非全员词库中的词条，该用户需要拥有对应词库的可见权限。</para>
    /// <para>示例值：7202510112396640276</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/lingo/v1/entities/match")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostLingoV1EntitiesMatchResponseDto>> PostLingoV1EntitiesMatchAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostLingoV1EntitiesMatchBodyDto dto,
        [PathQuery] string? repo_id = null);

    /// <summary>
    /// <para>【词典】模糊搜索词条</para>
    /// <para>接口ID：7249689905697095708</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/search</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>传入关键词，与词条名、别名、释义等信息进行模糊匹配，返回搜到的词条信息。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>每页返回的词条量</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：b152fa6e6f62a291019a04c3a93f365f8ac641910506ff15ff4cad6534e087cb4ed8fa2c</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="repo_id">
    /// <para>必填：否</para>
    /// <para>词库ID(不传时默认在全员词库内搜索)</para>
    /// <para>如以应用身份搜索非全员词库中的词条，需要在“词库设置”页面添加应用；若以用户身份搜索非全员词库中的词条，该用户需要拥有对应词库的可见权限。</para>
    /// <para>示例值：7202510112396640276</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/lingo/v1/entities/search")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostLingoV1EntitiesSearchResponseDto>> PostLingoV1EntitiesSearchAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostLingoV1EntitiesSearchBodyDto dto,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? repo_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【词典】获取词典分类</para>
    /// <para>接口ID：7249689905697161244</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/classification/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取飞书词典当前分类。</para>
    /// <para>飞书词典目前为二级分类体系，每个词条可添加多个二级分类，但选择的二级分类必须从属于不同的一级分类。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：20</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：408ecac018b2e3518db37275e812aad7bb8ad3e755fc886f322ac6c430ba</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="repo_id">
    /// <para>必填：否</para>
    /// <para>词库ID（不传默认范围为全员词库）</para>
    /// <para>如以应用身份获取非全员词库中的分类，需要在“词库设置”页面添加应用；若以用户身份获取非全员词库中的分类，该用户需要拥有对应词库的可见权限。</para>
    /// <para>示例值：7202510112396640276</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/lingo/v1/classifications")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetLingoV1ClassificationsResponseDto>> GetLingoV1ClassificationsAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 20,
        [PathQuery] string? page_token = null,
        [PathQuery] string? repo_id = null);

    /// <summary>
    /// <para>【词典】获取词库列表</para>
    /// <para>接口ID：7249689905697177628</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/repo/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取有权限访问的飞书词典词库列表。</para>
    /// <para>如以应用身份获取，需要在“词库设置”页面添加应用；若以用户身份获取，该用户需要拥有对应词库的可见权限。</para>
    /// </summary>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/lingo/v1/repos")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.GetLingoV1ReposResponseDto>> GetLingoV1ReposAsync(
        UserAccessToken access_token);

    /// <summary>
    /// <para>【词典】词条高亮</para>
    /// <para>接口ID：7249689905697210396</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/highlight</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>传入一句话，智能识别句中对应的词条，并返回词条位置和 entity_id，可在外部系统中快速实现词条智能高亮。</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/lingo/v1/entities/highlight")]
    System.Threading.Tasks.Task<FeishuResponse<Baike.PostLingoV1EntitiesHighlightResponseDto>> PostLingoV1EntitiesHighlightAsync(
        UserAccessToken access_token,
        [JsonContent] Baike.PostLingoV1EntitiesHighlightBodyDto dto);

    /// <summary>
    /// <para>【任务】创建任务</para>
    /// <para>接口ID：7255580838154371100</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口可以创建一个任务，在创建任务时，支持填写任务的基本信息（如标题、描述、负责人等），此外，还可以设置任务的开始时间、截止时间提醒等条件，此外，还可以通过传入 tasklists 字段将新任务加到多个清单中。</para>
    /// <para>创建任务时，可以通过设置`members`字段来设置任务的负责人和关注人。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？ ”章节。</para>
    /// <para>如果要设置任务的开始时间和截止时间，需要遵守任务时间的格式和约束。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何使用开始时间和截止时间？”章节。</para>
    /// <para>如要设置自定义字段值，可以设置`custom_fields`字段。但因为自定义字段归属于清单，因此要填写的自定义字段的guid必须归属于要添加的清单(通过`tasklists`设置）。详见[自定义字段概览](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/custom-field-overview)。</para>
    /// <para>通过设置`client_token`实现幂等调用。详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 幂等调用 ”章节。</para>
    /// <para>如要创建一个任务的子任务，需要使用[创建子任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task-subtask/create)接口。</para>
    /// <para>创建任务时可以一并设置自定义字段值。但根据自定义字段的权限关系，任务只能添加`tasklists`字段设置的清单中关联的自定义字段的值。详见[自定义字段功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/custom-field-overview)中的介绍。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksResponseDto>> PostTaskV2TasksAsync(
        UserAccessToken access_token,
        [JsonContent] Task.PostTaskV2TasksBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取评论详情</para>
    /// <para>接口ID：7255580838154387484</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给定一个评论的ID，返回评论的详情，包括内容，创建人，创建时间和更新时间等信息。</para>
    /// </summary>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要获取评论详情的评论ID</para>
    /// <para>示例值：7198104824246747156</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2CommentsByCommentIdResponseDto>> GetTaskV2CommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string comment_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】列取任务列表</para>
    /// <para>接口ID：7255580838154403868</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/list</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>基于调用身份，列出特定类型的所有任务。支持分页。</para>
    /// <para>目前只支持列取任务界面上“我负责的”任务。返回的任务数据按照任务在”我负责的“界面中”自定义拖拽“的顺序排序。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>每页的任务数量</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="completed">
    /// <para>必填：否</para>
    /// <para>是否按任务完成进行过滤。填写true表示只列出已完成任务；填写false表示只列出未完成任务。不填写表示不过滤。</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="type">
    /// <para>必填：否</para>
    /// <para>列取任务的类型，目前只支持"my_tasks"，即“我负责的”。</para>
    /// <para>示例值：my_tasks</para>
    /// <para>默认值：my_tasks</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasksResponseDto>> GetTaskV2TasksAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] bool? completed = null,
        [PathQuery] string? type = "my_tasks",
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新评论</para>
    /// <para>接口ID：7255580838154420252</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新一条评论。</para>
    /// <para>更新时，将`update_fields`字段中填写所有要修改的评论的字段名，同时在`comment`字段中填写要修改的字段的新值即可。更新接口规范详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
    /// <para>目前只支持更新评论的"conent"字段。</para>
    /// </summary>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的评论ID</para>
    /// <para>示例值：7198104824246747156</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2CommentsByCommentIdResponseDto>> PatchTaskV2CommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string comment_id,
        [JsonContent] Task.PatchTaskV2CommentsByCommentIdBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】列取任务所在清单</para>
    /// <para>接口ID：7255580838154453020</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/tasklists</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列取一个任务所在的所有清单的信息，包括清单的GUID和所在自定义分组的GUID。</para>
    /// <para>只有调用身份有权限访问的清单信息会被返回。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要获取清单列表的任务的全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasks/{task_guid}/tasklists")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasksByTaskGuidTasklistsResponseDto>> GetTaskV2TasksByTaskGuidTasklistsAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid);

    /// <summary>
    /// <para>【任务】创建清单</para>
    /// <para>接口ID：7255580838154469404</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建一个清单。清单可以用于组织和管理属于同一个项目的多个任务。</para>
    /// <para>创建时，必须填写清单的名字。同时，可以设置通过`members`字段设置清单的协作成员。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>创建清单后，创建人自动成为清单的所有者。如果请求同时将创建人设置为可编辑/可阅读角色，则最终该用户成为清单所有者，并自动从清单成员列表中消失。因为同一个用户在同一个清单只能拥有一个角色。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasklists")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasklistsResponseDto>> PostTaskV2TasklistsAsync(
        UserAccessToken access_token,
        [JsonContent] Task.PostTaskV2TasklistsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】添加清单成员</para>
    /// <para>接口ID：7255580838154485788</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/add_members</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>向一个清单添加1个或多个协作成员。成员信息通过设置`members`字段实现。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>一个清单协作成员可以是一个用户，应用或者群组。每个成员可以设置“可编辑”或者“可阅读”的角色。群组作为协作成员表示该群里所有群成员都自动拥有群组协作成员的角色。</para>
    /// <para>如果要添加的成员已经是清单成员，且角色和请求中设置是一样的，则会被自动忽略，接口返回成功。</para>
    /// <para>如果要添加的成员已经是清单成员，且角色和请求中设置是不一样的（比如原来的角色是可阅读，请求中设为可编辑），则相当于更新其角色。</para>
    /// <para>如果要添加的成员已经是清单的所有者，则会被自动忽略。接口返回成功。其所有者的角色不会改变。</para>
    /// <para>本接口不能用来设置清单所有者，如要设置，可以使用[更新清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/patch)接口。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要添加成员的清单的全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasklists/{tasklist_guid}/add_members")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasklistsByTasklistGuidAddMembersResponseDto>> PostTaskV2TasklistsByTasklistGuidAddMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [JsonContent] Task.PostTaskV2TasklistsByTasklistGuidAddMembersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】任务加入清单</para>
    /// <para>接口ID：7255580838154502172</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_tasklist</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将一个任务加入清单。返回任务的详细信息，包括任务所在的所有清单信息。</para>
    /// <para>如果任务已经在该清单，接口将返回成功。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要添加到清单的任务的全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/add_tasklist")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidAddTasklistResponseDto>> PostTaskV2TasksByTaskGuidAddTasklistAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidAddTasklistBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取任务的子任务列表</para>
    /// <para>接口ID：7255580838154518556</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task-subtask/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个任务的子任务列表。</para>
    /// <para>支持分页，数据按照子任务在界面上的顺序返回。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>父任务的全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasks/{task_guid}/subtasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasksByTaskGuidSubtasksResponseDto>> GetTaskV2TasksByTaskGuidSubtasksAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】创建子任务</para>
    /// <para>接口ID：7255580838154551324</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task-subtask/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给一个任务创建一个子任务。</para>
    /// <para>接口功能除了额外需要输入父任务的GUID之外，和[创建任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/create)接口功能完全一致。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>父任务GUID</para>
    /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/subtasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidSubtasksResponseDto>> PostTaskV2TasksByTaskGuidSubtasksAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidSubtasksBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除清单</para>
    /// <para>接口ID：7255580838154567708</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除一个清单。</para>
    /// <para>删除清单后，不可对该清单做任何操作，也无法再访问到清单。清单被删除后不可恢复。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要删除的清单GUID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v2/tasklists/{tasklist_guid}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV2TasklistsByTasklistGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid);

    /// <summary>
    /// <para>【任务】添加任务成员</para>
    /// <para>接口ID：7255580838154584092</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_members</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>添加任务的负责人或者关注人。一次性可以添加多个成员。返回任务的实体中会返回最终任务成员的列表。</para>
    /// <para>* 关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>* 成员的角色支持"assignee"和"follower"。</para>
    /// <para>* 成员类型支持"user"和"app"。</para>
    /// <para>* 如果要添加的成员已经在任务中，则自动被忽略。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要添加负责人的任务全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/add_members")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidAddMembersResponseDto>> PostTaskV2TasksByTaskGuidAddMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidAddMembersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】创建评论</para>
    /// <para>接口ID：7255580838154616860</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为一个任务创建评论，或者回复该任务的某个评论。</para>
    /// <para>若要创建一个回复评论，需要在创建时设置`reply_to_comment_id`字段。被回复的评论和新建的评论必须属于同一个任务。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/comments")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2CommentsResponseDto>> PostTaskV2CommentsAsync(
        UserAccessToken access_token,
        [JsonContent] Task.PostTaskV2CommentsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取任务详情</para>
    /// <para>接口ID：7255580838154633244</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于获取任务详情，包括任务标题、描述、时间、成员等信息。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要获取的任务guid</para>
    /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasks/{task_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasksByTaskGuidResponseDto>> GetTaskV2TasksByTaskGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除任务</para>
    /// <para>接口ID：7255580838154649628</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除一个任务。</para>
    /// <para>删除后任务无法再被获取到。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要删除的任务guid</para>
    /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v2/tasks/{task_guid}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV2TasksByTaskGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid);

    /// <summary>
    /// <para>【任务】获取清单详情</para>
    /// <para>接口ID：7255580838154666012</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个清单的详细信息，包括清单名，所有者，清单成员等。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>清单全局唯一GUID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasklists/{tasklist_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasklistsByTasklistGuidResponseDto>> GetTaskV2TasklistsByTasklistGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新清单</para>
    /// <para>接口ID：7255580838154682396</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新清单，可以更新清单的名字和所有者。</para>
    /// <para>更新清单时，将`update_fields`字段中填写所有要修改的清单字段名，同时在`tasklist`字段中填写要修改的字段的新值即可。更新调用规范详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
    /// <para>支持更新的字段包括:</para>
    /// <para>* `name` - 清单名字</para>
    /// <para>* `owner` - 清单所有者</para>
    /// <para>更新清单所有者（owner）时，如果该成员已经是清单的“可编辑”或者“可阅读”角色，则该成员将直接升级为所有者角色，自动从清单的成员列表中消失。这是因为同一个用户在同一个清单中只能有一个角色。同时，支持使用`origin_owner_to_role`字段将原有所有者变为可编辑/可阅读角色或者直接退出清单。</para>
    /// <para>该接口不能用于更新清单的成员和增删清单中的任务。</para>
    /// <para>* 如要增删清单中的成员，可以使用[添加清单成员](/ssl:ttdoc:/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/add_members)和[移除清单成员](/ssl:ttdoc:/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/remove_members)接口。</para>
    /// <para>* 如要增删清单中的任务，可以使用[任务加入清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_tasklist)和[任务移出清单]( https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_tasklist)接口。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的清单的全局唯一GUID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/tasklists/{tasklist_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2TasklistsByTasklistGuidResponseDto>> PatchTaskV2TasklistsByTasklistGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [JsonContent] Task.PatchTaskV2TasklistsByTasklistGuidBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取清单任务列表</para>
    /// <para>接口ID：7255580838154698780</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/tasks</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个清单的任务列表，返回任务的摘要信息。</para>
    /// <para>本接口支持分页。清单中的任务以“自定义拖拽”的顺序返回。</para>
    /// <para>本接口支持简单的按照任务的完成状态或者任务的创建时间范围过滤。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要获取任务的清单全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>每页返回的任务数量</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="completed">
    /// <para>必填：否</para>
    /// <para>只查看特定完成状态的任务，填写“true”表示返回已经完成的任务；“false”表示只返回未完成的任务；不填写表示不按完成状态过滤。</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="created_from">
    /// <para>必填：否</para>
    /// <para>任务创建的起始时间戳（ms），闭区间，不填写默认为首个任务的创建时间戳</para>
    /// <para>示例值：1675742789470</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="created_to">
    /// <para>必填：否</para>
    /// <para>任务创建的结束时间戳（ms），闭区间，不填写默认为最后创建任务的创建时间戳</para>
    /// <para>示例值：1675742789470</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasklists/{tasklist_guid}/tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasklistsByTasklistGuidTasksResponseDto>> GetTaskV2TasklistsByTasklistGuidTasksAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] bool? completed = null,
        [PathQuery] string? created_from = null,
        [PathQuery] string? created_to = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取清单列表</para>
    /// <para>接口ID：7255580838154715164</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取调用身份所有可读取的清单列表。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>每页返回的清单数量</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasklists")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasklistsResponseDto>> GetTaskV2TasklistsAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除评论</para>
    /// <para>接口ID：7255580838154731548</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除一条评论。</para>
    /// <para>评论被删除后，将无法进行任何操作，也无法恢复。</para>
    /// </summary>
    /// <param name="comment_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要删除的评论id</para>
    /// <para>示例值：7198104824246747156</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v2/comments/{comment_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV2CommentsByCommentIdAsync(
        UserAccessToken access_token,
        [PathQuery] string comment_id);

    /// <summary>
    /// <para>【任务】获取评论列表</para>
    /// <para>接口ID：7255580838154747932</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/comment/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给定一个资源，返回该资源的评论列表。</para>
    /// <para>支持分页。评论可以按照创建时间的正序（asc, 从最老到最新），或者逆序（desc，从最老到最新），返回数据。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小，默认为50。</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="resource_type">
    /// <para>必填：否</para>
    /// <para>要获取评论列表的资源类型，目前只支持"task"，默认为"task"。</para>
    /// <para>示例值：task</para>
    /// <para>默认值：task</para>
    /// </param>
    /// <param name="resource_id">
    /// <para>必填：是</para>
    /// <para>要获取评论的资源ID。例如要获取任务的评论列表，此处应该填写任务全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="direction">
    /// <para>必填：否</para>
    /// <para>返回数据的排序方式。"asc"表示从最老到最新顺序返回；"desc"表示从最新到最老顺序返回。默认为"asc"。</para>
    /// <para>示例值：asc</para>
    /// <list type="bullet">
    /// <item>asc：评论发表时间升序</item>
    /// <item>desc：评论发表时间降序</item>
    /// </list>
    /// <para>默认值：asc</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/comments")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2CommentsResponseDto>> GetTaskV2CommentsAsync(
        UserAccessToken access_token,
        [PathQuery] string resource_id,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? resource_type = "task",
        [PathQuery] string? direction = "asc",
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】任务移出清单</para>
    /// <para>接口ID：7255580838154780700</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_tasklist</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将任务从一个清单中移出。返回任务详情。</para>
    /// <para>如果任务不在清单中，接口将返回成功。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要从清单移除的任务的全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/remove_tasklist")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidRemoveTasklistResponseDto>> PostTaskV2TasksByTaskGuidRemoveTasklistAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidRemoveTasklistBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】移除任务成员</para>
    /// <para>接口ID：7255580838154797084</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_members</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>移除任务成员。一次性可以移除多个成员。可以移除任务的负责人或者关注人。移除时，如果要移除的成员不是任务成员，会被自动忽略。本接口返回移除成员后的任务数据，包含移除后的任务成员列表。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要移除成员的任务全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/remove_members")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidRemoveMembersResponseDto>> PostTaskV2TasksByTaskGuidRemoveMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidRemoveMembersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】添加任务提醒</para>
    /// <para>接口ID：7255580838154813468</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_reminders</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为一个任务添加提醒。提醒是基于任务的截止时间计算得到的一个时刻。为了设置提醒，任务必须首先拥有截止时间(due)。可以在[创建任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/create)时设置截止时间，或者通过[更新任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/patch)设置一个截止时间。</para>
    /// <para>目前一个任务只能设置1个提醒。但接口的形式可以在未来扩充为一个任务支持多个提醒。</para>
    /// <para>如果当前任务已经有提醒了，要更新提醒的设置，需要先调用[移除任务提醒](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_reminders)接口移除原有提醒。再调用本接口添加提醒。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要添加负责人的任务全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/add_reminders")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidAddRemindersResponseDto>> PostTaskV2TasksByTaskGuidAddRemindersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidAddRemindersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】移除任务提醒</para>
    /// <para>接口ID：7255580838154829852</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_reminders</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将一个提醒从任务中移除。</para>
    /// <para>如果要移除的提醒本来就不存在，本接口将直接返回成功。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要移除提醒的任务全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/remove_reminders")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidRemoveRemindersResponseDto>> PostTaskV2TasksByTaskGuidRemoveRemindersAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidRemoveRemindersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】移除清单成员</para>
    /// <para>接口ID：7255580838154846236</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/remove_members</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>移除清单的一个或多个协作成员。通过设置`members`字段表示要移除的成员信息。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>清单中同一个成员只能有一个角色，通过的member的id和type可以唯一确定一个成员，因此请求参数中对于要删除的成员，不需要填写"role"字段。</para>
    /// <para>如果要移除的成员不在清单中，则被自动忽略，接口返回成功。</para>
    /// <para>该接口不能用于移除清单所有者。如果要移除的成员是清单所有者，则会被自动忽略。如要设置清单所有者，需要调用[更新清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/patch)接口。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要移除协作人的清单全局唯一ID</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasklists/{tasklist_guid}/remove_members")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasklistsByTasklistGuidRemoveMembersResponseDto>> PostTaskV2TasklistsByTasklistGuidRemoveMembersAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [JsonContent] Task.PostTaskV2TasklistsByTasklistGuidRemoveMembersBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新任务</para>
    /// <para>接口ID：7255580838154879004</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于修改任务的标题、描述、截止时间等信息。</para>
    /// <para>更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`task`字段中填写要修改的字段的新值即可。如果`update_fields`中设置了要变更一个字段的名字，但是task里没设置新的值，则表示将该字段清空。调用约定详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
    /// <para>目前支持更新的字段包括：</para>
    /// <para>* `summary` - 任务标题</para>
    /// <para>* `description` - 任务描述</para>
    /// <para>* `start` - 任务开始时间</para>
    /// <para>* `due` - 任务截止时间</para>
    /// <para>* `completed_at` - 用于标记任务完成/未完成</para>
    /// <para>* `extra` - 任务附带自定义数据</para>
    /// <para>* `custom_complete` - 任务自定义完成配置。</para>
    /// <para>* `repeat_rule` - 重复任务规则。</para>
    /// <para>* `mode` - 任务完成模式。</para>
    /// <para>* `is_milestone` - 是否是里程碑任务。</para>
    /// <para>* `custom_fields` - 自定义字段值。</para>
    /// <para>该接口可以用于完成任务和将任务恢复至未完成，只需要修改`completed_at`字段即可。但留意，目前不管任务本身是会签任务还是或签任务，oapi对任务进行完成只能实现“整体完成”，不支持个人单独完成。此外，不能对已经完成的任务再次完成，但可以将其恢复到未完成的状态(设置`completed_at`为"0")。</para>
    /// <para>如更新自定义字段的值，需要调用身份同时拥有任务的编辑权限和自定义字段的编辑权限。详情见[自定义字段功能概览](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/custom-field-overview)。更新时，只有填写在`task.custom_fields`的自定义字段值会被更新，不填写的不会被改变。</para>
    /// <para>任务成员/提醒/清单数据不能使用本接口进行更新。</para>
    /// <para>* 如要修改任务成员，需要使用[添加任务成员](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_members)</para>
    /// <para>和[移除任务成员](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_members)接口。</para>
    /// <para>* 如要修改任务提醒，需要使用[添加任务提醒](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_reminders)和[移除任务提醒](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_reminders)接口。</para>
    /// <para>* 如要变更任务所在的清单，需要使用[任务加入清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_tasklist)和[任务移出清单]( https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_tasklist)接口。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的任务全局唯一ID</para>
    /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/tasks/{task_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2TasksByTaskGuidResponseDto>> PatchTaskV2TasksByTaskGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PatchTaskV2TasksByTaskGuidBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【通讯录】获取单个职务信息</para>
    /// <para>接口ID：7256700963174989828</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口可以获取单个职务的信息。</para>
    /// </summary>
    /// <param name="job_title_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>职务ID</para>
    /// <para>示例值：dd39369b19b9</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/job_titles/{job_title_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3JobTitlesByJobTitleIdResponseDto>> GetContactV3JobTitlesByJobTitleIdAsync(
        UserAccessToken access_token,
        [PathQuery] string job_title_id);

    /// <summary>
    /// <para>【通讯录】获取租户职务列表</para>
    /// <para>接口ID：7256700963175006212</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口可用于获取租户下职务列表信息。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值："xxx"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/job_titles")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3JobTitlesResponseDto>> GetContactV3JobTitlesAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【通讯录】获取单个工作城市信息</para>
    /// <para>接口ID：7256700963175022596</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口可用于获取单个工作城市信息。</para>
    /// </summary>
    /// <param name="work_city_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>工作城市ID</para>
    /// <para>示例值：dd39369b19b9</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/work_cities/{work_city_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3WorkCitiesByWorkCityIdResponseDto>> GetContactV3WorkCitiesByWorkCityIdAsync(
        UserAccessToken access_token,
        [PathQuery] string work_city_id);

    /// <summary>
    /// <para>【通讯录】获取租户工作城市列表</para>
    /// <para>接口ID：7256700963175038980</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>此接口可用于获取租户下工作城市列表信息。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值："xxx"</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/contact/v3/work_cities")]
    System.Threading.Tasks.Task<FeishuResponse<Contact.GetContactV3WorkCitiesResponseDto>> GetContactV3WorkCitiesAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【任务】创建自定义分组</para>
    /// <para>接口ID：7259330038033809436</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为清单或我负责的任务列表创建一个自定义分组。创建时可以需要提供名称和可选的配置。如果不指定位置，新分组会放到指定resource的自定义分组列表的最后。</para>
    /// <para>当在清单中创建自定义分组时，需要设置`resourse_type`为"tasklist", `resource_id`设为清单的GUID。</para>
    /// <para>当为我负责任务列表中创建自定义分组时，需要设置`resource_type`为"my_tasks"，不需要设置`resource_id`。调用身份只能为自己的我负责的任务列表创建自定义分组。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/sections")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2SectionsResponseDto>> PostTaskV2SectionsAsync(
        UserAccessToken access_token,
        [JsonContent] Task.PostTaskV2SectionsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取自定义分组详情</para>
    /// <para>接口ID：7259330038033825820</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个自定义分组详情，包括名称，创建人等信息。如果该自定义分组归属于一个清单，还会返回清单的摘要信息。</para>
    /// </summary>
    /// <param name="section_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要获取的自定义分组GUID</para>
    /// <para>示例值：9842501a-9f47-4ff5-a622-d319eeecb97f</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/sections/{section_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2SectionsBySectionGuidResponseDto>> GetTaskV2SectionsBySectionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string section_guid,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新自定义分组</para>
    /// <para>接口ID：7259330038033842204</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新自定义分组，可以更新自定义分组的名称和位置。</para>
    /// <para>更新时，将`update_fields`字段中填写所有要修改的字段名，同时在`section`字段中填写要修改的字段的新值即可。调用约定详情见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 关于资源的更新”章节。</para>
    /// <para>目前支持更新的字段包括：</para>
    /// <para>* `name` - 自定义字段名字;</para>
    /// <para>* `insert_before` - 要让当前自定义分组放到某个自定义分组前面的secion_guid，用于改变当前自定义分组的位置;</para>
    /// <para>* `insert_after` - 要让当前自定义分组放到某个自定义分组后面的secion_guid，用于改变当前自定义分组的位置。</para>
    /// <para>`insert_before`和`insert_after`如果填写，必须是同一个资源的合法section_guid。注意不能同时设置`insert_before`和`insert_after`。</para>
    /// </summary>
    /// <param name="section_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的自定义分组GUID</para>
    /// <para>示例值：9842501a-9f47-4ff5-a622-d319eeecb97f</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/sections/{section_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2SectionsBySectionGuidResponseDto>> PatchTaskV2SectionsBySectionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string section_guid,
        [JsonContent] Task.PatchTaskV2SectionsBySectionGuidBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除自定义分组</para>
    /// <para>接口ID：7259330038033858588</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>删除一个自定义分组。删除后该自定义分组中的任务会被移动到被删除自定义分组所属资源的默认自定义分组中。</para>
    /// <para>不能删除默认的自定义分组。</para>
    /// </summary>
    /// <param name="section_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要删除的自定义分组全局唯一ID</para>
    /// <para>示例值：9842501a-9f47-4ff5-a622-d319eeecb97f</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v2/sections/{section_guid}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV2SectionsBySectionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string section_guid);

    /// <summary>
    /// <para>【任务】获取自定义分组列表</para>
    /// <para>接口ID：7259330038033874972</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取一个资源下所有的自定义分组列表。支持分页。返回结果按照自定义分组在界面上的顺序排序。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="resource_type">
    /// <para>必填：是</para>
    /// <para>自定义分组所属的资源类型。支持my_tasks(我负责的）和tasklist（清单）。当使用tasklist时，需要用resource_id提供清单的全局唯一ID。</para>
    /// <para>示例值：tasklist</para>
    /// </param>
    /// <param name="resource_id">
    /// <para>必填：否</para>
    /// <para>如`resource_type`为"tasklist"，这里需要填写要列取自定义分组的清单的GUID。</para>
    /// <para>示例值：caef228f-2342-23c1-c36d-91186414dc64</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/sections")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2SectionsResponseDto>> GetTaskV2SectionsAsync(
        UserAccessToken access_token,
        [PathQuery] string resource_type,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? resource_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取自定义分组任务列表</para>
    /// <para>接口ID：7259330038033891356</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/section/tasks</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列取一个自定义分组里的所有任务。支持分页。任务按照自定义排序的顺序返回。本接口支持简单的过滤。</para>
    /// </summary>
    /// <param name="section_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要获取任务的自定义分组全局唯一ID</para>
    /// <para>示例值：9842501a-9f47-4ff5-a622-d319eeecb97f</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="completed">
    /// <para>必填：否</para>
    /// <para>按照任务状态过滤，如果不填写则表示不按完成状态过滤</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="created_from">
    /// <para>必填：否</para>
    /// <para>按照创建时间筛选的起始时间戳（ms)，如不填写则为首个任务的创建时刻</para>
    /// <para>示例值：1675742789470</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="created_to">
    /// <para>必填：否</para>
    /// <para>按照创建时间筛选的起始时间戳（ms)，如不填写则为最后任务的创建时刻</para>
    /// <para>示例值：1675742789470</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/sections/{section_guid}/tasks")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2SectionsBySectionGuidTasksResponseDto>> GetTaskV2SectionsBySectionGuidTasksAsync(
        UserAccessToken access_token,
        [PathQuery] string section_guid,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] bool? completed = null,
        [PathQuery] string? created_from = null,
        [PathQuery] string? created_to = null);

    /// <summary>
    /// <para>【云文档】取消云文档事件订阅</para>
    /// <para>接口ID：7259592279886233628</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete_subscribe</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口仅支持**文档拥有者**和**文档管理者**取消订阅文档的通知事件（但目前文档管理者仅能接收到**文件编辑**事件）。可订阅的文档类型为**旧版文档**、**新版文档**、**电子表格**和**多维表格**。暂时无法指定取消的具体事件类型，事件类型以开发者后台为准。在调用该接口之前请确保正确[配置事件回调网址和订阅事件类型](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM#2eb3504a)，事件类型参考[事件列表](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-list)。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doccnxxxxxxxxxxxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>docx：doc</item>
    /// <item>sheet：表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>file：文件</item>
    /// <item>folder：文件夹</item>
    /// </list>
    /// </param>
    /// <param name="event_type">
    /// <para>必填：否</para>
    /// <para>事件类型，订阅为folder类型时必填</para>
    /// <para>示例值：file.created_in_folder_v1</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/drive/v1/files/{file_token}/delete_subscribe")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteDriveV1FilesByFileTokenDeleteSubscribeAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [PathQuery] string? event_type = null);

    /// <summary>
    /// <para>【云文档】查询云文档事件订阅状态</para>
    /// <para>接口ID：7259592279886250012</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/get_subscribe</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口仅支持**文档拥有者**和**文档管理者**查询文档的订阅状态（但目前文档管理者仅能接收到**文件编辑**事件）。可订阅的文档类型为**旧版文档**、**新版文档**、**电子表格**和**多维表格**。在调用该接口之前请确保正确[配置事件回调网址和订阅事件类型](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM#2eb3504a)，事件类型参考[事件列表](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-list)。</para>
    /// </summary>
    /// <param name="file_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>文档token</para>
    /// <para>示例值：doccnxxxxxxxxxxxxxxxxxxxxxx</para>
    /// </param>
    /// <param name="file_type">
    /// <para>必填：是</para>
    /// <para>文档类型</para>
    /// <para>示例值：doc</para>
    /// <list type="bullet">
    /// <item>doc：文档</item>
    /// <item>docx：docx文档</item>
    /// <item>sheet：表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>file：文件</item>
    /// <item>folder：文件夹</item>
    /// </list>
    /// </param>
    /// <param name="event_type">
    /// <para>必填：否</para>
    /// <para>事件类型，订阅为folder类型时必填</para>
    /// <para>示例值：file.created_in_folder_v1</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/drive/v1/files/{file_token}/get_subscribe")]
    System.Threading.Tasks.Task<FeishuResponse<Ccm.GetDriveV1FilesByFileTokenGetSubscribeResponseDto>> GetDriveV1FilesByFileTokenGetSubscribeAsync(
        UserAccessToken access_token,
        [PathQuery] string file_token,
        [PathQuery] string file_type,
        [PathQuery] string? event_type = null);

    /// <summary>
    /// <para>【日历】解绑会议群</para>
    /// <para>接口ID：7263360328350728196</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-meeting_chat/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）为日程解绑已创建的会议群。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。</para>
    /// <para>示例值：feishu.cn_xxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>示例值：75d28f9b-e35c-4230-8a83-123_0</para>
    /// </param>
    /// <param name="meeting_chat_id">
    /// <para>必填：是</para>
    /// <para>会议群 ID。在创建会议群时会返回会议群 ID。</para>
    /// <para>示例值：oc_xxx</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/meeting_chat")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [PathQuery] string meeting_chat_id);

    /// <summary>
    /// <para>【日历】创建会议群</para>
    /// <para>接口ID：7263360328350744580</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event-meeting_chat/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）为指定日程创建一个会议群。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。了解更多，参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_xxx@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：75d28f9b-e35c-4230-8a83-123_0</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/meeting_chat")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatResponseDto>> PostCalendarV4CalendarsByCalendarIdEventsByEventIdMeetingChatAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id);

    /// <summary>
    /// <para>【任务】将自定义字段加入资源</para>
    /// <para>接口ID：7270765454292189186</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/add</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将自定义字段加入一个资源。目前资源类型支持清单tasklist。一个自定义字段可以加入多个清单中。加入后，该清单可以展示任务的该字段的值，同时基于该字段实现筛选，分组等功能。</para>
    /// <para>如果自定义字段的设置被更新，字段加入的所有字段都能收到这个更新，并进行相应的展示。</para>
    /// </summary>
    /// <param name="custom_field_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义字段GUID。自定义字段GUID。可以通过[创建自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/create)接口创建, 或者通过[列取自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/list)接口查询得到。</para>
    /// <para>示例值：0110a4bd-f24b-4a93-8c1a-1732b94f9593</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/custom_fields/{custom_field_guid}/add")]
    System.Threading.Tasks.Task<FeishuResponse> PostTaskV2CustomFieldsByCustomFieldGuidAddAsync(
        UserAccessToken access_token,
        [PathQuery] string custom_field_guid,
        [JsonContent] Task.PostTaskV2CustomFieldsByCustomFieldGuidAddBodyDto dto);

    /// <summary>
    /// <para>【任务】将自定义字段移出资源</para>
    /// <para>接口ID：7270765454292205570</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/remove</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>将自定义字段从资源中移出。移除后，该资源将无法再使用该字段。目前资源的类型支持"tasklist"。</para>
    /// <para>如果要移除自定义字段本来就不存在于资源，本接口将正常返回。</para>
    /// <para>注意自定义字段是通过清单来实现授权的，如果将自定义字段从所有关联的清单中移除，就意味着任何调用身份都无法再访问改自定义字段。</para>
    /// </summary>
    /// <param name="custom_field_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义字段GUID。自定义字段GUID。可以通过[创建自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/create)接口创建, 或者通过[列取自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/list)接口查询得到。</para>
    /// <para>示例值：0110a4bd-f24b-4a93-8c1a-1732b94f9593</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/custom_fields/{custom_field_guid}/remove")]
    System.Threading.Tasks.Task<FeishuResponse> PostTaskV2CustomFieldsByCustomFieldGuidRemoveAsync(
        UserAccessToken access_token,
        [PathQuery] string custom_field_guid,
        [JsonContent] Task.PostTaskV2CustomFieldsByCustomFieldGuidRemoveBodyDto dto);

    /// <summary>
    /// <para>【任务】更新自定义字段选项</para>
    /// <para>接口ID：7270765454292221954</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据一个自定义字段的GUID和其选项的GUID，更新该选项的数据。要更新的字段必须是单选或者多选类型，且要更新的字段必须归属于该字段。</para>
    /// <para>更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`option`字段中填写要修改的字段的新值即可。`update_fields`支持的字段包括：</para>
    /// <para>* `name`: 选项名称</para>
    /// <para>* `color_index`: 选项的颜色索引值</para>
    /// <para>* `is_hidden`: 是否从界面上隐藏</para>
    /// <para>* `insert_before`: 将当前option放到同字段某个option之前的那个option_guid。</para>
    /// <para>* `insert_after`: 将当前option放到同字段某个option之后的那个option_guid。</para>
    /// </summary>
    /// <param name="custom_field_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的选项的自定义字段GUID</para>
    /// <para>示例值：ec5ed63d-a4a9-44de-a935-7ba243471c0a</para>
    /// </param>
    /// <param name="option_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的选项的GUID</para>
    /// <para>示例值：b13adf3c-cad6-4e02-8929-550c112b5633</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/custom_fields/{custom_field_guid}/options/{option_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidResponseDto>> PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string custom_field_guid,
        [PathQuery] string option_guid,
        [JsonContent] Task.PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidBodyDto dto);

    /// <summary>
    /// <para>【任务】获取自定义字段</para>
    /// <para>接口ID：7270765454292238338</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>根据一个自定义字段的GUID，获取其详细的设置信息。</para>
    /// </summary>
    /// <param name="custom_field_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义字段GUID。可以通过[创建自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/create)接口创建, 或者通过[列取自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/list)接口查询得到。</para>
    /// <para>示例值：5ffbe0ca-6600-41e0-a634-2b38cbcf13b8</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/custom_fields/{custom_field_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2CustomFieldsByCustomFieldGuidResponseDto>> GetTaskV2CustomFieldsByCustomFieldGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string custom_field_guid,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新自定义字段</para>
    /// <para>接口ID：7270765454292254722</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新一个自定义字段的名称和设定。更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`custom_field`字段中填写要修改的字段的新值即可。自定义字段不允许修改类型，只能根据类型修改其设置。</para>
    /// <para>`update_fields`支持更新的字段包括：</para>
    /// <para>* `name`：自定义字段名称</para>
    /// <para>* `number_setting` ：数字类型设置（当且仅当要更新的自定义字段类型是数字时)</para>
    /// <para>* `member_setting` ：人员类型设置（当且仅当要更新的自定义字段类型是人员时)</para>
    /// <para>* `datetime_setting` ：日期类型设置 (当且仅当要更新的自定义字段类型是日期时)</para>
    /// <para>* `single_select_setting`：单选类型设置 (当且仅当要更新的自定义字段类型是单选时)</para>
    /// <para>* `multi_select_setting`：多选类型设置 (当且仅当要更新的自定义字段类型是多选时)</para>
    /// <para>* `text_setting`: 文本类型设置（目前文本类型没有可设置项）</para>
    /// <para>当更改某个设置时，如果不填写一个字段，表示不覆盖原有的设定。比如，对于一个数字，原有的setting是:</para>
    /// <para>```json</para>
    /// <para>"number_setting": {</para>
    /// <para>"format": "normal",</para>
    /// <para>"decimal_count": 2,</para>
    /// <para>"separator": "none",</para>
    /// <para>"custom_symbol": "L",</para>
    /// <para>"custom_symbol_position": "right"</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>使用如下参数调用接口：</para>
    /// <para>```</para>
    /// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
    /// <para>{</para>
    /// <para>"custom_field": {</para>
    /// <para>"number_setting": {</para>
    /// <para>"decimal_count": 4</para>
    /// <para>}</para>
    /// <para>},</para>
    /// <para>"update_fields": ["number_setting"]</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>表示仅仅将小数位数从2改为4，其余的设置`format`, `separator`, `custom_field`等都不变。</para>
    /// <para>对于单选/多选类型的自定义字段，其设定是一个选项列表。更新时，使用方式接近使用App的界面。使用者不必传入字段的所有选项，而是只需要提供最终希望界面可见（is_hidden=false) 的选项。原有字段中的选项如果没有出现在输入中，则被置为`is_hidden=true`并放到所有可见选项之后。</para>
    /// <para>对于某一个更新的选项，如果提供了option_guid，将视作更新该选项（此时option_guid必须存在于当前字段，否则会返回错误）；如果不提供，将视作新建一个选项（新的选项的option_guid会在reponse中被返回)。</para>
    /// <para>例如，一个单选字段原来有3个选项A，B，C，D。其中C是隐藏的。用户可以这样更新选项：</para>
    /// <para>```</para>
    /// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
    /// <para>{</para>
    /// <para>"custom_field": {</para>
    /// <para>"single_select_setting": {</para>
    /// <para>"optoins": [</para>
    /// <para>{</para>
    /// <para>"name": "E",</para>
    /// <para>"color_index": 25</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"guid": "&lt;option_guid of A&gt;"</para>
    /// <para>"name": "A2"</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"guid": "&lt;option_guid of C&gt;",</para>
    /// <para>},</para>
    /// <para>]</para>
    /// <para>}</para>
    /// <para>},</para>
    /// <para>"update_fields": ["single_select_setting"]</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>调用后最终得到了新的选项列表E, A, C, B, D。其中：</para>
    /// <para>* 选项E被新建出来，其`color_index`被设为了25。</para>
    /// <para>* 选项A被更新，其名称被改为了"A2"。但其color_index因为没有设置而保持不变；</para>
    /// <para>* 选项整体顺序遵循用户的输入顺序，即E，A，C。同时E，A，C作为直接的输入，其is_hidden均被设为了false，其中，C原本是is_hidden=true，也会被设置为is_hidden=false。</para>
    /// <para>* 选项B和D因为用户没有输入，其`is_hidden`被置为了true，并且被放到了所有用户输入的选项之后。</para>
    /// <para>如果只是单纯的希望修改用户可见的选项的顺序，比如从原本的选项A,B,C修改为C,B,A，可以这样调用接口：</para>
    /// <para>```</para>
    /// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
    /// <para>{</para>
    /// <para>"custom_field": {</para>
    /// <para>"single_select_setting": {</para>
    /// <para>"optoins": [</para>
    /// <para>{</para>
    /// <para>"guid": "&lt;option_guid_of_C&gt;"</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"guid": "&lt;option_guid of B&gt;"</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"guid": "&lt;option_guid of A&gt;",</para>
    /// <para>},</para>
    /// <para>]</para>
    /// <para>}</para>
    /// <para>},</para>
    /// <para>"update_fields": ["single_select_setting"]</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>如果希望直接将字段里的所有选项都标记为不可见，可以这样调用接口：</para>
    /// <para>```</para>
    /// <para>PATCH /task/v2/custom_fields/:custom_field_guid</para>
    /// <para>{</para>
    /// <para>"custom_field": {</para>
    /// <para>"single_select_setting": {</para>
    /// <para>"optoins": []</para>
    /// <para>}</para>
    /// <para>},</para>
    /// <para>"update_fields": ["single_select_setting"]</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>更新单选/多选字段的选项必须满足“可见选项名字不能重复”的约束。否则会返回错误。开发者需要自行保证输入的选项名不可以重复。</para>
    /// <para>如希望只更新单个选项，或者希望单独设置某个选项的is_hidden，本接口无法支持，但可以使用[更新自定义字段选项](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/patch)接口实现。</para>
    /// </summary>
    /// <param name="custom_field_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>自定义字段GUID。自定义字段GUID。可以通过[创建自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/create)接口创建, 或者通过[列取自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/list)接口查询得到。</para>
    /// <para>示例值：5ffbe0ca-6600-41e0-a634-2b38cbcf13b8</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/custom_fields/{custom_field_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2CustomFieldsByCustomFieldGuidResponseDto>> PatchTaskV2CustomFieldsByCustomFieldGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string custom_field_guid,
        [JsonContent] Task.PatchTaskV2CustomFieldsByCustomFieldGuidBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】列取自定义字段</para>
    /// <para>接口ID：7270765454292271106</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列取用户可访问的自定义字段列表。如果不提供`resource_type`和`resource_id`参数，则返回用户可访问的所有自定义字段。</para>
    /// <para>如果提供`resource_type`和`resource_id`，则返回该资源下的自定义字段。目前`resource_type`仅支持"tasklist"，此时`resource_id`应为一个清单的tasklist_guid。</para>
    /// <para>该接口支持分页。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="resource_type">
    /// <para>必填：否</para>
    /// <para>资源类型，如提供表示仅查询特定资源下的自定义字段。目前只支持tasklist。</para>
    /// <para>示例值：tasklist</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="resource_id">
    /// <para>必填：否</para>
    /// <para>要查询自定义字段的归属resource_id</para>
    /// <para>示例值：5ffbe0ca-6600-41e0-a634-2b38cbcf13b8</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/custom_fields")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2CustomFieldsResponseDto>> GetTaskV2CustomFieldsAsync(
        UserAccessToken access_token,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? resource_type = null,
        [PathQuery] string? resource_id = null);

    /// <summary>
    /// <para>【任务】创建自定义任务选项</para>
    /// <para>接口ID：7270765454292287490</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field-option/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为单选或多选字段添加一个自定义选项。一个单选/多选字段最大支持100个选项。</para>
    /// <para>新添加的选项如果不隐藏，其名字不能和已存在的不隐藏选项的名字重复。</para>
    /// </summary>
    /// <param name="custom_field_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要添加选项的自定义字段GUID，该字段必须是</para>
    /// <para>示例值：b13adf3c-cad6-4e02-8929-550c112b5633</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/custom_fields/{custom_field_guid}/options")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDto>> PostTaskV2CustomFieldsByCustomFieldGuidOptionsAsync(
        UserAccessToken access_token,
        [PathQuery] string custom_field_guid,
        [JsonContent] Task.PostTaskV2CustomFieldsByCustomFieldGuidOptionsBodyDto dto);

    /// <summary>
    /// <para>【任务】创建自定义字段</para>
    /// <para>接口ID：7270765454292320258</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/custom_field/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>创建一个自定义字段，并将其加入一个资源上（目前资源只支持清单）。创建自定义字段必须提供字段名称，类型和相应类型的设置。</para>
    /// <para>目前任务自定义字段支持数字(number)，成员(member)，日期(datetime)，单选(single_select),多选(multi_select), 文本(text)几种类型。分别使用"number_setting", "member_setting", "datetime_setting", "single_select_setting", "multi_select_setting","text_setting"来设置。</para>
    /// <para>例如创建一个数字类型的自定义字段，并添加到guid为"ec5ed63d-a4a9-44de-a935-7ba243471c0a"的清单，可以这样发请求。</para>
    /// <para>```</para>
    /// <para>POST /task/v2/custom_fields</para>
    /// <para>{</para>
    /// <para>"name": "价格",</para>
    /// <para>"type": "number",</para>
    /// <para>"resource_type": "tasklist",</para>
    /// <para>"resource_id": "ec5ed63d-a4a9-44de-a935-7ba243471c0a",</para>
    /// <para>"number_setting": {</para>
    /// <para>"format": "cny",</para>
    /// <para>"decimal_count": 2,</para>
    /// <para>"separator": "thousand"</para>
    /// <para>}</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>表示创建一个叫做“价格”的自定义字段，保留两位小数。在界面上显示时采用人民币的格式，并显示千分位分割符。</para>
    /// <para>类似的，创建一个单选字段，可以这样调用接口：</para>
    /// <para>```</para>
    /// <para>POST /task/v2/custom_fields</para>
    /// <para>{</para>
    /// <para>"name": "优先级",</para>
    /// <para>"type": "single_select",</para>
    /// <para>"resource_type": "tasklist",</para>
    /// <para>"resource_id": "ec5ed63d-a4a9-44de-a935-7ba243471c0a",</para>
    /// <para>"single_select_setting": {</para>
    /// <para>"options": [</para>
    /// <para>{</para>
    /// <para>"name": "高",</para>
    /// <para>"color_index": 1</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"name": "中",</para>
    /// <para>"color_index": 11</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"name": "低",</para>
    /// <para>"color_index": 16</para>
    /// <para>}</para>
    /// <para>]</para>
    /// <para>}</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>表示创建一个叫“优先级”的单选，包含“高”，“中”，“低”三个选项，每个选项设置一个颜色值。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/custom_fields")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2CustomFieldsResponseDto>> PostTaskV2CustomFieldsAsync(
        UserAccessToken access_token,
        [JsonContent] Task.PostTaskV2CustomFieldsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【绩效】获取周期任务（指定用户）</para>
    /// <para>接口ID：7275704938197221378</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/stage_task/find_by_user_list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取指定周期的指定用户的任务信息</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// <item>people_admin_id：以people_admin_id来识别用户</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/performance/v1/stage_tasks/find_by_user_list")]
    System.Threading.Tasks.Task<FeishuResponse<Performance.PostPerformanceV1StageTasksFindByUserListResponseDto>> PostPerformanceV1StageTasksFindByUserListAsync(
        UserAccessToken access_token,
        [JsonContent] Performance.PostPerformanceV1StageTasksFindByUserListBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】移除依赖</para>
    /// <para>接口ID：7277445986133442563</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_dependencies</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>从一个任务移除一个或者多个依赖。移除时只需要输入要移除的`task_guid`即可。</para>
    /// <para>注意，如果要移除的依赖非当前任务的依赖，会被自动忽略。接口会返回成功。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要移除依赖的任务GUID</para>
    /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/remove_dependencies")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidRemoveDependenciesResponseDto>> PostTaskV2TasksByTaskGuidRemoveDependenciesAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidRemoveDependenciesBodyDto dto);

    /// <summary>
    /// <para>【任务】添加依赖</para>
    /// <para>接口ID：7277445986133458947</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_dependencies</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为一个任务添加一个或多个依赖。可以添加任务的前置依赖和后置依赖。存在依赖关系的任务如果在同一个清单，可以通过清单的甘特图来展示其依赖关系。</para>
    /// <para>本接口也可以用于修改一个现有依赖的类型（前置改为后置或者后置改为前置）。</para>
    /// <para>注意：添加的依赖的`task_guid`不能重复，也不能添加当前任务为自己的依赖。尝试添加一个已经存在的依赖会被自动忽略。</para>
    /// </summary>
    /// <param name="task_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>任务GUID</para>
    /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasks/{task_guid}/add_dependencies")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasksByTaskGuidAddDependenciesResponseDto>> PostTaskV2TasksByTaskGuidAddDependenciesAsync(
        UserAccessToken access_token,
        [PathQuery] string task_guid,
        [JsonContent] Task.PostTaskV2TasksByTaskGuidAddDependenciesBodyDto dto);

    /// <summary>
    /// <para>【任务】列取动态订阅</para>
    /// <para>接口ID：7288897051646951426</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给定一个清单的GUID，获取其所有的订阅信息。结果按照订阅的创建时间排序。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>清单GUID。可以通过[创建清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/create)，或者通过[获取清单列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/list)接口查询得到。</para>
    /// <para>示例值：d19e3a2a-edc0-4e4e-b7cc-950e162b53ae</para>
    /// </param>
    /// <param name="limit">
    /// <para>必填：否</para>
    /// <para>返回结果的最大数量</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasklists/{tasklist_guid}/activity_subscriptions")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsResponseDto>> GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [PathQuery] int? limit = 50,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】更新动态订阅</para>
    /// <para>接口ID：7288897051646967810</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>提供一个清单的GUID和一个动态订阅的GUID，对其进行更新。更新时，将`update_fields`字段中填写所有要修改的字段名，同时在`activity_subscription`字段中填写要修改的字段的新值即可。</para>
    /// <para>`update_fields`支持更新的字段包括：</para>
    /// <para>* name：订阅的名称</para>
    /// <para>* subscribers: 订阅者列表。如更新，会将旧的订阅者列表完全替换为新的订阅者列表。支持最大50个订阅者。并且订阅者必须是chat类型。</para>
    /// <para>* include_keys ：订阅需要发送通知的key。如更新，会将旧的列表完全替换为新的include_keys列表。只能设置支持的event key (见字段描述）。</para>
    /// <para>* disabled：修改订阅的开启/禁用状态。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>清单GUID。可以通过[创建清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/create)，或者通过[获取清单列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/list)接口查询得到。</para>
    /// <para>示例值：33991879-704f-444f-81d7-55a6aa7be80c</para>
    /// </param>
    /// <param name="activity_subscription_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要更新的动态订阅GUID。可以通过[创建动态订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/create)接口创建，或者通过[列取动态订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/list)查询得到。</para>
    /// <para>示例值：f5ca6747-5ac3-422e-a97e-972c1b2c24f3</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/task/v2/tasklists/{tasklist_guid}/activity_subscriptions/{activity_subscription_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidResponseDto>> PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [PathQuery] string activity_subscription_guid,
        [JsonContent] Task.PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除动态订阅</para>
    /// <para>接口ID：7288897051646984194</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>给定一个清单的GUID和一个订阅的GUID，将其删除。删除后的数据不可恢复。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>清单GUID。可以通过[创建清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/create)，或者通过[获取清单列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/list)接口查询得到。</para>
    /// <para>示例值：f5ca6747-5ac3-422e-a97e-972c1b2c24f3</para>
    /// </param>
    /// <param name="activity_subscription_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要删除的订阅GUID。可以通过[创建动态订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/create)接口创建，或者通过[列取动态订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/list)查询得到。</para>
    /// <para>示例值：d19e3a2a-edc0-4e4e-b7cc-950e162b53ae</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v2/tasklists/{tasklist_guid}/activity_subscriptions/{activity_subscription_guid}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [PathQuery] string activity_subscription_guid);

    /// <summary>
    /// <para>【任务】创建动态订阅</para>
    /// <para>接口ID：7288897051647000578</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为一个清单创建一个订阅。每个订阅可以包含1个或多个订阅者（目前只支持普通群组）。订阅创建后，如清单发生相应的事件，则会向订阅里的订阅者发送通知消息。一个清单最多可以创建50个订阅。每个订阅最大支持50个订阅者。订阅者目前仅支持"chat"类型。</para>
    /// <para>每个订阅可以通过设置`include_keys`可以针对哪些事件(event_key)做通知。如果`include_keys`为空，则不对任何事件进行通知。</para>
    /// <para>如有需要，创建时也可以直接将`disabled`设为true，创建一个禁止发送订阅通知的订阅。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>清单GUID</para>
    /// <para>示例值：d19e3a2a-edc0-4e4e-b7cc-950e162b53ae</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/tasklists/{tasklist_guid}/activity_subscriptions")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsResponseDto>> PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [JsonContent] Task.PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取动态订阅</para>
    /// <para>接口ID：7288897051647016962</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>提供一个清单的GUID和一个订阅的GUID，获取该订阅的详细信息，包括名称，订阅者，可通知的event key列表等。</para>
    /// </summary>
    /// <param name="tasklist_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>清单GUID。可以通过[创建清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/create)，或者通过[获取清单列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/list)接口查询得到。</para>
    /// <para>示例值：33991879-704f-444f-81d7-55a6aa7be80c</para>
    /// </param>
    /// <param name="activity_subscription_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>订阅GUID。可以通过[创建动态订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/create)接口创建，或者通过[列取动态订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/list)查询得到。</para>
    /// <para>示例值：33991879-704f-444f-81d7-55a6aa7be80c</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/tasklists/{tasklist_guid}/activity_subscriptions/{activity_subscription_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidResponseDto>> GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string tasklist_guid,
        [PathQuery] string activity_subscription_guid,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】上传附件</para>
    /// <para>接口ID：7297183031634460675</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/upload</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>为特定资源上传附件。本接口可以支持一次上传多个附件，最多5个。每个附件尺寸不超过50MB，格式不限。</para>
    /// <para>上传请求体的格式为"form-data"。若希望上传多个附件，则提供多个"file"字段即可。返回的附件顺序将会与输入的file顺序保持一致。</para>
    /// <para>目前资源类型仅支持"task", `resource_id`需要填写任务的GUID。</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>要上传的文件，单请求支持最多5个文件。上传结果的顺序将和请求中文件的顺序保持一致。</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/task/v2/attachments/upload")]
    System.Threading.Tasks.Task<FeishuResponse<Task.PostTaskV2AttachmentsUploadResponseDto>> PostTaskV2AttachmentsUploadAsync(
        UserAccessToken access_token,
        [FormDataContent] Task.PostTaskV2AttachmentsUploadBodyDto dto,
        [FormDataContent] FormDataFile file,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】列取附件</para>
    /// <para>接口ID：7297183031634477059</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>列取一个资源的所有附件。返回的附件列表支持分页，按照附件上传时间排序。</para>
    /// <para>每个附件会返回一个可供下载的临时url，有效期为3分钟，最多可以支持3次下载。如果超过使用限制，需要通过本接口获取新的临时url。</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：50</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="resource_type">
    /// <para>必填：否</para>
    /// <para>附件归属的资源类型。目前只支持"task"。</para>
    /// <para>示例值：task</para>
    /// <para>默认值：task</para>
    /// </param>
    /// <param name="resource_id">
    /// <para>必填：是</para>
    /// <para>附件归属资源的id，配合resource_type使用。例如希望获取任务的附件，需要设置 resource_type为task， resource_id为任务GUID。任务GUID的获取方式可以参考[任务功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)。</para>
    /// <para>示例值：9842501a-9f47-4ff5-a622-d319eeecb97f</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/attachments")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2AttachmentsResponseDto>> GetTaskV2AttachmentsAsync(
        UserAccessToken access_token,
        [PathQuery] string resource_id,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null,
        [PathQuery] string? resource_type = "task",
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】获取附件</para>
    /// <para>接口ID：7297183031634493443</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/get</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>提供一个附件GUID，返回附件的详细信息，包括GUID，名称，大小，上传时间，临时可下载链接等。</para>
    /// </summary>
    /// <param name="attachment_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>获取详情的附件GUID。可以通过创建[上传附件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/upload)接口创建, 或者通过[列取附件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/list)接口查询得到。</para>
    /// <para>示例值：b59aa7a3-e98c-4830-8273-cbb29f89b837</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/task/v2/attachments/{attachment_guid}")]
    System.Threading.Tasks.Task<FeishuResponse<Task.GetTaskV2AttachmentsByAttachmentGuidResponseDto>> GetTaskV2AttachmentsByAttachmentGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string attachment_guid,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【任务】删除附件</para>
    /// <para>接口ID：7297183031634509827</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/delete</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>提供一个附件GUID，删除该附件。删除后该附件不可再恢复。</para>
    /// </summary>
    /// <param name="attachment_guid">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>要删除附件的GUID。可以通过创建[上传附件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/upload)接口创建, 或者通过[列取附件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/list)接口查询得到。</para>
    /// <para>示例值：b59aa7a3-e98c-4830-8273-cbb29f89b837</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/task/v2/attachments/{attachment_guid}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteTaskV2AttachmentsByAttachmentGuidAsync(
        UserAccessToken access_token,
        [PathQuery] string attachment_guid);

    /// <summary>
    /// <para>【飞书人事】更新公司</para>
    /// <para>接口ID：7309323790810824705</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/patch</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>更新公司信息。</para>
    /// </summary>
    /// <param name="company_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>需要更新的公司 ID</para>
    /// <para>示例值：1616161616</para>
    /// </param>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>根据client_token是否一致来判断是否为同一请求</para>
    /// <para>示例值：12454646</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPatch("/open-apis/corehr/v1/companies/{company_id}")]
    System.Threading.Tasks.Task<FeishuResponse<FeishuPeople.PatchCorehrV1CompaniesByCompanyIdResponseDto>> PatchCorehrV1CompaniesByCompanyIdAsync(
        UserAccessToken access_token,
        [PathQuery] string company_id,
        [JsonContent] FeishuPeople.PatchCorehrV1CompaniesByCompanyIdBodyDto dto,
        [PathQuery] string? client_token = null);

    /// <summary>
    /// <para>【多维表格】查询记录</para>
    /// <para>接口ID：7312729248342360068</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/search</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>该接口用于查询数据表中的现有记录，单次最多查询 500 行记录，支持分页获取。</para>
    /// </summary>
    /// <param name="app_token">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表格token</para>
    /// <para>示例值：NQRxbRkBMa6OnZsjtERcxhNWnNh</para>
    /// </param>
    /// <param name="table_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>表ID</para>
    /// <para>示例值：tbl0xe5g8PP3U3cS</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>分页大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：20</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/bitable/v1/apps/{app_token}/tables/{table_id}/records/search")]
    System.Threading.Tasks.Task<FeishuResponse<Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchResponseDto>> PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchAsync(
        UserAccessToken access_token,
        [PathQuery] string app_token,
        [PathQuery] string table_id,
        [JsonContent] Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchBodyDto dto,
        [PathQuery] string? user_id_type = "open_id",
        [PathQuery] string? page_token = null,
        [PathQuery] int? page_size = 20);

    /// <summary>
    /// <para>【薪酬管理】批量查询员工薪资档案</para>
    /// <para>接口ID：7314129756769746948</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>批量查询员工薪资档案</para>
    /// </summary>
    /// <param name="page_size">
    /// <para>必填：是</para>
    /// <para>分页大小</para>
    /// <para>示例值：100</para>
    /// <para>默认值：100</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：231432433</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：是</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/compensation/v1/archives/query")]
    System.Threading.Tasks.Task<FeishuResponse<CompensationManagement.PostCompensationV1ArchivesQueryResponseDto>> PostCompensationV1ArchivesQueryAsync(
        UserAccessToken access_token,
        [JsonContent] CompensationManagement.PostCompensationV1ArchivesQueryBodyDto dto,
        [PathQuery] int page_size = 100,
        [PathQuery] string? page_token = null,
        [PathQuery] string user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】回复日程</para>
    /// <para>接口ID：7317471576948834305</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/reply</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）回复日程。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程所在的日历 ID。了解更多，参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_HF9U2MbibE8PPpjro6xjqa@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：75d28f9b-e35c-4230-8a83-4a661497db54_0</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/reply")]
    System.Threading.Tasks.Task<FeishuResponse> PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [JsonContent] Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyBodyDto dto);

    /// <summary>
    /// <para>【日历】获取重复日程实例</para>
    /// <para>接口ID：7317471576948850689</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/instances</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以当前身份（应用或用户）获取指定日历中的某一重复日程信息。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_HF9U2MbibE8PPpjro6xjqa@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="event_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日程 ID。</para>
    /// <para>创建日程时会返回日程 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)</para>
    /// <para>- [搜索日程](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/search)</para>
    /// <para>示例值：75d28f9b-e35c-4230-8a83-4a661497db54_0</para>
    /// </param>
    /// <param name="start_time">
    /// <para>必填：是</para>
    /// <para>开始时间，Unix 时间戳，单位为秒。该参数与 end_time 用于设置时间范围，即重复日程的查询区间为 （start_time, end_time）</para>
    /// <para>**注意**：start_time 与 end_time 之间的时间区间不能超过 2年。</para>
    /// <para>示例值：1631777271</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：是</para>
    /// <para>结束时间，Unix 时间戳，单位为秒。该参数与 start_time 用于设置时间范围，即重复日程的查询区间为 （start_time, end_time）</para>
    /// <para>**注意**：start_time 与 end_time 之间的时间区间不能超过 2年。</para>
    /// <para>示例值：1631777271</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>一次调用返回的日程数量上限。</para>
    /// <para>示例值：10</para>
    /// <para>默认值：50</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/events/{event_id}/instances")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesResponseDto>> GetCalendarV4CalendarsByCalendarIdEventsByEventIdInstancesAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string event_id,
        [PathQuery] string start_time,
        [PathQuery] string end_time,
        [PathQuery] int? page_size = 50,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【AI 能力】识别文件中的机动车发票</para>
    /// <para>接口ID：7319756481343750148</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/vehicle_invoice/recognize</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>机动车发票识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
    /// </summary>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>识别的机动车发票源文件</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/document_ai/v1/vehicle_invoice/recognize")]
    System.Threading.Tasks.Task<FeishuResponse<Ai.PostDocumentAiV1VehicleInvoiceRecognizeResponseDto>> PostDocumentAiV1VehicleInvoiceRecognizeAsync(
        UserAccessToken access_token,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【AI 能力】识别文件中的健康证</para>
    /// <para>接口ID：7319756481343766532</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/health_certificate/recognize</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>健康证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
    /// </summary>
    /// <param name="file">
    /// <para>必填：是</para>
    /// <para>识别的健康证源文件</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/document_ai/v1/health_certificate/recognize")]
    System.Threading.Tasks.Task<FeishuResponse<Ai.PostDocumentAiV1HealthCertificateRecognizeResponseDto>> PostDocumentAiV1HealthCertificateRecognizeAsync(
        UserAccessToken access_token,
        [FormDataContent] FormDataFile file);

    /// <summary>
    /// <para>【智能门禁】添加访客</para>
    /// <para>接口ID：7321978105899057180</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/visitor/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>添加访客</para>
    /// </summary>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/acs/v1/visitors")]
    System.Threading.Tasks.Task<FeishuResponse<Acs.PostAcsV1VisitorsResponseDto>> PostAcsV1VisitorsAsync(
        UserAccessToken access_token,
        [JsonContent] Acs.PostAcsV1VisitorsBodyDto dto,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【智能门禁】设备绑定权限组</para>
    /// <para>接口ID：7321978105899073564</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/rule_external/device_bind</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>设备绑定权限组</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/acs/v1/rule_external/device_bind")]
    System.Threading.Tasks.Task<FeishuResponse> PostAcsV1RuleExternalDeviceBindAsync(
        UserAccessToken access_token,
        [JsonContent] Acs.PostAcsV1RuleExternalDeviceBindBodyDto dto);

    /// <summary>
    /// <para>【智能门禁】获取权限组信息</para>
    /// <para>接口ID：7321978105899089948</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/rule_external/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>获取权限组信息</para>
    /// </summary>
    /// <param name="device_id">
    /// <para>必填：否</para>
    /// <para>设备id</para>
    /// <para>示例值：7296700518380863767</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/acs/v1/rule_external")]
    System.Threading.Tasks.Task<FeishuResponse<Acs.GetAcsV1RuleExternalResponseDto>> GetAcsV1RuleExternalAsync(
        UserAccessToken access_token,
        [PathQuery] string? device_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【智能门禁】删除权限组</para>
    /// <para>接口ID：7321978105899106332</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/rule_external/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>删除权限组</para>
    /// </summary>
    /// <param name="rule_id">
    /// <para>必填：是</para>
    /// <para>权限组id</para>
    /// <para>示例值：7298933941867135276</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/acs/v1/rule_external")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteAcsV1RuleExternalAsync(
        UserAccessToken access_token,
        [PathQuery] string rule_id);

    /// <summary>
    /// <para>【智能门禁】创建或更新权限组</para>
    /// <para>接口ID：7321978105899122716</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/rule_external/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>创建或更新权限组</para>
    /// </summary>
    /// <param name="rule_id">
    /// <para>必填：否</para>
    /// <para>权限组id-为空创建,不为空则更新</para>
    /// <para>示例值：7298933941867135276</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/acs/v1/rule_external")]
    System.Threading.Tasks.Task<FeishuResponse<Acs.PostAcsV1RuleExternalResponseDto>> PostAcsV1RuleExternalAsync(
        UserAccessToken access_token,
        [JsonContent] Acs.PostAcsV1RuleExternalBodyDto dto,
        [PathQuery] string? rule_id = null,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【智能门禁】删除访客</para>
    /// <para>接口ID：7321978105899139100</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/acs-v1/visitor/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>删除访客</para>
    /// </summary>
    /// <param name="visitor_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>访客id</para>
    /// <para>示例值：6939433228970082566</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/acs/v1/visitors/{visitor_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteAcsV1VisitorsByVisitorIdAsync(
        UserAccessToken access_token,
        [PathQuery] string visitor_id,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【日历】查询日程视图</para>
    /// <para>接口ID：7322810271218647043</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/instance_view</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>调用该接口以用户身份查询指定日历下的日程视图。与[获取日程列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/list)不同的是，当前接口会按照重复日程的重复性规则展开成多个日程实例（instance），并根据查询的时间区间返回相应的日程实例信息。</para>
    /// </summary>
    /// <param name="calendar_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>日历 ID。关于日历 ID 可参见[日历 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/introduction)。</para>
    /// <para>示例值：feishu.cn_HF9U2MbibE8PPpjro6xjqa@group.calendar.feishu.cn</para>
    /// </param>
    /// <param name="start_time">
    /// <para>必填：是</para>
    /// <para>开始时间，Unix 时间戳，单位为秒。该参数与 end_time 用于设置查询的时间范围。</para>
    /// <para>**注意**：start_time 与 end_time 之间的时间区间需要小于 40 天。</para>
    /// <para>示例值：1631777271</para>
    /// </param>
    /// <param name="end_time">
    /// <para>必填：是</para>
    /// <para>结束时间，Unix 时间戳，单位为秒。该参数与 start_time 用于设置查询的时间范围。</para>
    /// <para>**注意**：start_time 与 end_time 之间的时间区间需要小于 40 天。</para>
    /// <para>示例值：1631777271</para>
    /// </param>
    /// <param name="user_id_type">
    /// <para>必填：否</para>
    /// <para>用户 ID 类型</para>
    /// <para>示例值：open_id</para>
    /// <list type="bullet">
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。[了解更多：如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。[了解更多：如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</item>
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。[了解更多：如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</item>
    /// </list>
    /// <para>默认值：open_id</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/calendar/v4/calendars/{calendar_id}/events/instance_view")]
    System.Threading.Tasks.Task<FeishuResponse<Calendar.GetCalendarV4CalendarsByCalendarIdEventsInstanceViewResponseDto>> GetCalendarV4CalendarsByCalendarIdEventsInstanceViewAsync(
        UserAccessToken access_token,
        [PathQuery] string calendar_id,
        [PathQuery] string start_time,
        [PathQuery] string end_time,
        [PathQuery] string? user_id_type = "open_id");

    /// <summary>
    /// <para>【画板】获取所有节点</para>
    /// <para>接口ID：7338460461824360449</para>
    /// <para>接口文档：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/list</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>获取画板内所有的节点</para>
    /// </summary>
    /// <param name="whiteboard_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>画板唯一标识</para>
    /// <para>示例值：Ru8nwrWFOhEmaFbEU2VbPRsHcxb</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/board/v1/whiteboards/{whiteboard_id}/nodes")]
    System.Threading.Tasks.Task<FeishuResponse<Board.GetBoardV1WhiteboardsByWhiteboardIdNodesResponseDto>> GetBoardV1WhiteboardsByWhiteboardIdNodesAsync(
        UserAccessToken access_token,
        [PathQuery] string whiteboard_id);

    /// <summary>
    /// <para>【飞书人事（企业版）】添加人员</para>
    /// <para>接口ID：7350663854198161410</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/create</para>
    /// <para>Authorization：tenant_access_token、user_access_token</para>
    /// <para>支持在单个接口中进行人员全信息添加，包括人员基本信息，雇佣信息，任职记录及其他分组信息</para>
    /// </summary>
    /// <param name="client_token">
    /// <para>必填：否</para>
    /// <para>操作的唯一标识，用于幂等的进行更新操作，格式为标准的 UUIDV4。此值为空表示将发起一次新的请求，此值非空表示幂等的进行更新操作。</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="rehire">
    /// <para>必填：否</para>
    /// <para>是否为离职重聘</para>
    /// <para>- false：系统直接标为非离职重聘人员，不再做重复判断</para>
    /// <para>- true：要求 rehire_employment_id</para>
    /// <para>示例值：true</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="rehire_employment_id">
    /// <para>必填：否</para>
    /// <para>离职重聘员工雇佣 ID</para>
    /// <para>可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>示例值：7140964208476371111</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="force_submit">
    /// <para>必填：否</para>
    /// <para>是否强制提交</para>
    /// <para>超编等场景需要用户确认影响才能提交</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </param>
    /// <param name="ignore_working_hours_type_rule">
    /// <para>必填：否</para>
    /// <para>是否忽略工时制度自动生成规则</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/corehr/v2/employees")]
    System.Threading.Tasks.Task<FeishuResponse<Corehr.PostCorehrV2EmployeesResponseDto>> PostCorehrV2EmployeesAsync(
        UserAccessToken access_token,
        [JsonContent] Corehr.PostCorehrV2EmployeesBodyDto dto,
        [PathQuery] string? client_token = null,
        [PathQuery] bool? rehire = null,
        [PathQuery] string? rehire_employment_id = null,
        [PathQuery] bool? force_submit = false,
        [PathQuery] bool? ignore_working_hours_type_rule = false);

    /// <summary>
    /// <para>【智能伙伴创建平台】获取消息</para>
    /// <para>接口ID：7358047310868152324</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-aily_message/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于获取某个飞书智能伙伴应用的消息（Message）的详细信息；包括消息的内容、发送人等。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="aily_message_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>消息 ID</para>
    /// <para>示例值：message_4df45f2xknvcc</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/aily/v1/sessions/{aily_session_id}/messages/{aily_message_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.GetAilyV1SessionsByAilySessionIdMessagesByAilyMessageIdResponseDto>> GetAilyV1SessionsByAilySessionIdMessagesByAilyMessageIdAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [PathQuery] string aily_message_id);

    /// <summary>
    /// <para>【智能伙伴创建平台】列出消息</para>
    /// <para>接口ID：7358047310868168708</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-aily_message/list</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于列出某个飞书智能伙伴应用的某个会话（Session）下消息（Message）的详细信息；包括消息的内容、发送人等。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>页面大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="run_id">
    /// <para>必填：否</para>
    /// <para>运行 ID</para>
    /// <para>示例值：run_4dfrxvctjqzzj</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/aily/v1/sessions/{aily_session_id}/messages")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.GetAilyV1SessionsByAilySessionIdMessagesResponseDto>> GetAilyV1SessionsByAilySessionIdMessagesAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null,
        [PathQuery] string? run_id = null);

    /// <summary>
    /// <para>【智能伙伴创建平台】创建运行</para>
    /// <para>接口ID：7358047310868185092</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于在某个飞书智能伙伴应用会话（Session）上创建一次运行（Run）。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/aily/v1/sessions/{aily_session_id}/runs")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.PostAilyV1SessionsByAilySessionIdRunsResponseDto>> PostAilyV1SessionsByAilySessionIdRunsAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [JsonContent] Aily.PostAilyV1SessionsByAilySessionIdRunsBodyDto dto);

    /// <summary>
    /// <para>【智能伙伴创建平台】列出运行</para>
    /// <para>接口ID：7358047310868201476</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/list</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于列出某个飞书智能伙伴应用的运行（Run）的详细信息；包括状态、结束时间等。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="page_size">
    /// <para>必填：否</para>
    /// <para>页面大小</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </param>
    /// <param name="page_token">
    /// <para>必填：否</para>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// <para>默认值：null</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/aily/v1/sessions/{aily_session_id}/runs")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.GetAilyV1SessionsByAilySessionIdRunsResponseDto>> GetAilyV1SessionsByAilySessionIdRunsAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [PathQuery] int? page_size = 10,
        [PathQuery] string? page_token = null);

    /// <summary>
    /// <para>【智能伙伴创建平台】取消运行</para>
    /// <para>接口ID：7358047310868217860</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/cancel</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于取消某个飞书智能伙伴应用的运行（Run）。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="run_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>运行 ID</para>
    /// <para>示例值：run_4dfrxvctjqzzj</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/aily/v1/sessions/{aily_session_id}/runs/{run_id}/cancel")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelResponseDto>> PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [PathQuery] string run_id);

    /// <summary>
    /// <para>【智能伙伴创建平台】更新会话</para>
    /// <para>接口ID：7358047310868234244</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session/update</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于更新与某个飞书智能伙伴应用的一次会话（Session）的信息。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPut("/open-apis/aily/v1/sessions/{aily_session_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.PutAilyV1SessionsByAilySessionIdResponseDto>> PutAilyV1SessionsByAilySessionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [JsonContent] Aily.PutAilyV1SessionsByAilySessionIdBodyDto dto);

    /// <summary>
    /// <para>【智能伙伴创建平台】获取会话</para>
    /// <para>接口ID：7358047310868250628</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于获取与某个飞书智能伙伴应用的一次会话（Session）的详细信息，包括会话的状态、渠道上下文、创建时间等。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/aily/v1/sessions/{aily_session_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.GetAilyV1SessionsByAilySessionIdResponseDto>> GetAilyV1SessionsByAilySessionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id);

    /// <summary>
    /// <para>【智能伙伴创建平台】删除会话</para>
    /// <para>接口ID：7358047310868267012</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session/delete</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于删除与某个飞书智能伙伴应用的一次会话（Session）。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpDelete("/open-apis/aily/v1/sessions/{aily_session_id}")]
    System.Threading.Tasks.Task<FeishuResponse> DeleteAilyV1SessionsByAilySessionIdAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id);

    /// <summary>
    /// <para>【智能伙伴创建平台】发送消息</para>
    /// <para>接口ID：7358047310868283396</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-aily_message/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于向某个飞书智能伙伴应用发送一条消息（Message）；每个消息从属于一个活跃的会话（Session）。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/aily/v1/sessions/{aily_session_id}/messages")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.PostAilyV1SessionsByAilySessionIdMessagesResponseDto>> PostAilyV1SessionsByAilySessionIdMessagesAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [JsonContent] Aily.PostAilyV1SessionsByAilySessionIdMessagesBodyDto dto);

    /// <summary>
    /// <para>【智能伙伴创建平台】获取运行</para>
    /// <para>接口ID：7358047310868299780</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/get</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于获取某个飞书智能伙伴应用的运行（Run）的详细信息；包括运行的状态、结束时间等。</para>
    /// </summary>
    /// <param name="aily_session_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>会话 ID</para>
    /// <para>示例值：session_4dfunz7sp1g8m</para>
    /// </param>
    /// <param name="run_id">
    /// <para>路径参数</para>
    /// <para>必填：是</para>
    /// <para>运行 ID</para>
    /// <para>示例值：run_4dfrxvctjqzzj</para>
    /// </param>
    /// <param name="access_token">用户凭证</param>
    [HttpGet("/open-apis/aily/v1/sessions/{aily_session_id}/runs/{run_id}")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.GetAilyV1SessionsByAilySessionIdRunsByRunIdResponseDto>> GetAilyV1SessionsByAilySessionIdRunsByRunIdAsync(
        UserAccessToken access_token,
        [PathQuery] string aily_session_id,
        [PathQuery] string run_id);

    /// <summary>
    /// <para>【智能伙伴创建平台】创建会话</para>
    /// <para>接口ID：7358047310868316164</para>
    /// <para>接口文档：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session/create</para>
    /// <para>Authorization：user_access_token</para>
    /// <para>该 API 用于创建与某个飞书智能伙伴应用的一次会话（Session）；当创建会话成功后，可以发送消息、创建运行</para>
    /// </summary>
    /// <param name="dto">请求体</param>
    /// <param name="access_token">用户凭证</param>
    [HttpPost("/open-apis/aily/v1/sessions")]
    System.Threading.Tasks.Task<FeishuResponse<Aily.PostAilyV1SessionsResponseDto>> PostAilyV1SessionsAsync(
        UserAccessToken access_token,
        [JsonContent] Aily.PostAilyV1SessionsBodyDto dto);
}

