
using System;
using System.Text;

using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CEN.NeuralPlay;



/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CP.NeuralPlay_Invitacion_aceptarInvitacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CP.NeuralPlay
{
public partial class InvitacionCP : GenericBasicCP
{
public void AceptarInvitacion (int p_oid, int p_oid_usuario_receptor)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CP.NeuralPlay_Invitacion_aceptarInvitacion) ENABLED START*/





        try
        {
                CPSession.SessionInitializeTransaction ();

                InvitacionCEN invCEN = new InvitacionCEN (CPSession.UnitRepo.InvitacionRepository);
                MiembroComunidadCEN miemComunidadCEN = new MiembroComunidadCEN (CPSession.UnitRepo.MiembroComunidadRepository);

                InvitacionEN invEN = invCEN.ReadOID (p_oid);
                if (invEN == null)
                        throw new Exception ("Invitacion no encontrada.");

                if (invEN.Comunidad == null)
                        throw new Exception ("La invitacion no est� asociada a ninguna comunidad.");

                // Crear miembro de comunidad
                miemComunidadCEN.New_ (
                        Enumerated.NeuralPlay.RolComunidadEnum.Miembro,
                        Enumerated.NeuralPlay.EstadoMembresiaEnum.Activa,
                        DateTime.Now,
                        invEN.Comunidad.Id,
                        p_oid_usuario_receptor
                        );

                //Desvincular la comunidad antes de eliminar la invitaci�n
                invEN.Comunidad.Invitacion = null;
                CPSession.UnitRepo.ComunidadRepository.Modify (invEN.Comunidad);

                //Ahora s�, eliminar la invitaci�n
                invCEN.Destroy (p_oid);

                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw new Exception ("Error al aceptar la invitaci�n de comunidad: " + ex.Message, ex);
        }
        finally
        {
                CPSession.SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
