
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CEN.NeuralPlay_MiembroEquipo_banearMiembro) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
public partial class MiembroEquipoCEN
{
public void BanearMiembro (int p_oid)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CEN.NeuralPlay_MiembroEquipo_banearMiembro) ENABLED START*/

        MiembroEquipoEN miembroEN = _IMiembroEquipoRepository.ReadOIDDefault (p_oid);


        if (miembroEN != null) {
                miembroEN.Estado = Enumerated.NeuralPlay.EstadoMembresiaEnum.Expulsada;


                _IMiembroEquipoRepository.ModifyDefault (miembroEN);
        }

        /*PROTECTED REGION END*/
}
}
}
