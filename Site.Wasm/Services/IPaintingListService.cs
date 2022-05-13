using System;
using System.Linq;
using System.Net.Http.Json;
using Site.Wasm.Models;

namespace Site.Wasm.Services
{
	public interface IPaintingListService
    {
        Task<List<Painting>> GetPaintings();
    }

    public class PaintingListService : IPaintingListService
    {
        private readonly HttpClient httpClient;

        public PaintingListService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Painting>> GetPaintings() =>
            (await httpClient.GetFromJsonAsync<Painting[]>("data/paintings.json"))?.ToList() ??
                throw new Exception();
    }
}