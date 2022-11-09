using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Repository {
    public class LogErroRepository {
        private readonly ClinicaContext _dbContext;

        public LogErroRepository(ClinicaContext dbContext) { 
            _dbContext = dbContext;
        }

        public void Adicionar(Exception ex) {
            var logErro = new LogErro();

            logErro.InnerException = ex.InnerException?.ToString();
            logErro.StackTrace = ex.StackTrace;
            logErro.Mensagem = ex.Message;
            logErro.DataHoraRegistro = DateTime.Now;

            _dbContext.LogErros.Add(logErro);
            _dbContext.SaveChanges();
        }
    }
}
