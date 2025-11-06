
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CEN.NeuralPlay_PerfilJuego_actualizarFechaAccion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
public partial class PerfilJuegoCEN
{
public void ActualizarFechaAccion (int p_oid)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CEN.NeuralPlay_PerfilJuego_actualizarFechaAccion) ENABLED START*/

        PerfilJuegoEN perfilJuegoEN = _IPerfilJuegoRepository.ReadOIDDefault (p_oid);

        if (perfilJuegoEN != null) {
                perfilJuegoEN.FechaAccion = DateTime.Now;

                _IPerfilJuegoRepository.ModifyDefault (perfilJuegoEN);
        }

        /*PROTECTED REGION END*/
}
}
}
