import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("🔍 Extrayendo datos de DeviceContext...");

  const deviceContextClass = Il2Cpp.domain.assemblies
    .flatMap(assembly => assembly.image.classes)
    .find(cls => cls.name === "DeviceContext");

  if (!deviceContextClass) {
    console.error("❌ No se encontró la clase DeviceContext.");
    return;
  }

  const getMainDeviceContextMethod = deviceContextClass.methods.find(m => m.name === "get_MainDeviceContext");
  if (!getMainDeviceContextMethod) {
    console.error("❌ No se encontró el método get_MainDeviceContext.");
    return;
  }

  try {
    const deviceContextInstance = getMainDeviceContextMethod.invoke() as Il2Cpp.Object;
    console.log("✅ Instancia de DeviceContext obtenida:", deviceContextInstance);

    const sessionToken = deviceContextInstance.field("<SessionToken>k__BackingField").value as unknown as string;
    const account = deviceContextInstance.field("<Account>k__BackingField").value as unknown as string;
    const playerId = deviceContextInstance.field("<PlayerId>k__BackingField").value as unknown as string;

    console.log("📌 SessionToken:", sessionToken);
    console.log("📌 Account:", account);
    console.log("📌 PlayerId:", playerId);

  } catch (e) {
    console.error("❌ Error al obtener campos de DeviceContext:", e);
  }
});
