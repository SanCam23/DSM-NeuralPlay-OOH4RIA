
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IPublicacionRepository
{
void setSessionCP (GenericSessionCP session);

PublicacionEN ReadOIDDefault (int id
                              );

void ModifyDefault (PublicacionEN publicacion);

System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size);



int New_ (PublicacionEN publicacion);

void Modify (PublicacionEN publicacion);


void Destroy (int id
              );


PublicacionEN ReadOID (int id
                       );


System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size);
}
}
