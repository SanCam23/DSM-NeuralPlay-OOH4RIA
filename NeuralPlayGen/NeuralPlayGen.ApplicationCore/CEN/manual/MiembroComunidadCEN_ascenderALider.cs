
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;


/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CEN.NeuralPlay_MiembroComunidad_ascenderALider) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CEN.NeuralPlay
{
public partial class MiembroComunidadCEN
{
public void AscenderALider (int p_oid)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CEN.NeuralPlay_MiembroComunidad_ascenderALider) ENABLED START*/


        MiembroComunidadEN miembroEN = _IMiembroComunidadRepository.ReadOIDDefault (p_oid);

        if (miembroEN == null) {
                throw new Exception ("Miembro no encontrado");
        }


        if (miembroEN.Rol == Enumerated.NeuralPlay.RolComunidadEnum.Colaborador ||
            miembroEN.Rol == Enumerated.NeuralPlay.RolComunidadEnum.Miembro) {
                miembroEN.Rol = Enumerated.NeuralPlay.RolComunidadEnum.Lider;
                _IMiembroComunidadRepository.ModifyDefault (miembroEN);
        }

        /*PROTECTED REGION END*/
}
}
}
