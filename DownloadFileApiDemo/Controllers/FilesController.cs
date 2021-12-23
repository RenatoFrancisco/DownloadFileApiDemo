using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace DownloadFileApiDemo.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class FilesController : ControllerBase
{
    [HttpGet("download/filePath")]
    public async Task<IActionResult> DownloadFile(string filePath)
    {
        if (!System.IO.File.Exists(filePath)) return BadRequest("Arquivo não encontrado");

        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(filePath, out var contentType))
            contentType = "application/octet-stream";

        var bytes = await System.IO.File.ReadAllBytesAsync(filePath);
        return File(bytes, contentType, Path.GetFileName(filePath));
    }
}