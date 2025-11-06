
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IMiembroComunidadRepository
{
void setSessionCP (GenericSessionCP session);

MiembroComunidadEN ReadOIDDefault (int id
                                   );

void ModifyDefault (MiembroComunidadEN miembroComunidad);

System.Collections.Generic.IList<MiembroComunidadEN> ReadAllDefault (int first, int size);



int New_ (MiembroComunidadEN miembroComunidad);

void Modify (MiembroComunidadEN miembroComunidad);


void Destroy (int id
              );


MiembroComunidadEN ReadOID (int id
                            );


System.Collections.Generic.IList<MiembroComunidadEN> ReadAll (int first, int size);
}
}
