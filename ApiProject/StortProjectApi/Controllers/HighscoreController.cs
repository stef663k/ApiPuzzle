using System;
using Microsoft.AspNetCore.Mvc;
using StortProjectApi.Models;
using StortProjectApi.Services;

namespace StortProjectApi.Controllers;

[Controller]
[Route("/")]
public class HighscoreController: Controller
{
    private readonly HighscoreService _service;

    public HighscoreController(HighscoreService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<HighscoreModel>> GetHighscoresAsync() {
        return await _service.GetHighScoreList();
    }

    [HttpPost]
    public async Task<IActionResult> SaveHighscores([FromBody]HighscoreModel model) {
        await _service.CreateHighScore(model);
        return Ok(model);
    }
}