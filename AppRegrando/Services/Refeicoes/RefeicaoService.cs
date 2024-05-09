using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRegrando.Models;
using System.Collections.ObjectModel;

namespace AppRegrando.Services.Refeicoes
{
    public class RefeicaoService : Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "https://xyz.azurewebsites.net/Refeicoes";
        //xyz --> site da sua API

        private string _token;

        public RefeicaoService(string token)
        {
            _request = new Request();
            _token = token;
        }

        public async Task<int> PostRefeicaoAsync(Refeicao r)
        {
            return await _request.PostReturnIntAsync(apiUrlBase, r, _token);
        }
        public async Task<ObservableCollection<Refeicao>> GetRefeicoesAsync()
        {
            string urlComplementar = string.Format("{0}", "/GetAll");
            ObservableCollection<Models.Refeicao> listaRefeicoes = await
         _request.GetAsync<ObservableCollection<Models.Refeicao>>(apiUrlBase + urlComplementar, _token);
            return listaRefeicoes;
        }
        public async Task<Refeicao> GetRefeicaoAsync(int refeicaoId)
        {
            string urlComplementar = string.Format("/{0}", refeicaoId);
            var refeicao = await _request.GetAsync<Models.Refeicao>(apiUrlBase + urlComplementar, _token);
            return refeicao;
        }
        public async Task<int> PutRefeicaoAsync(Refeicao r)
        {
            var result = await _request.PutAsync(apiUrlBase, r, _token);
            return result;
        }
        public async Task<int> DeleteRefeicaoAsync(int refeicaoId)
        {
            string urlComplementar = string.Format("/{0}", refeicaoId);
            var result = await _request.DeleteAsync(apiUrlBase + urlComplementar, _token);
            return result;
        }
    }
}
