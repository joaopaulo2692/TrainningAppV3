// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
//self.addEventListener('fetch', () => { });

self.addEventListener('install', event => {
    event.waitUntil(
        caches.open('my-cache').then(cache => {
            return cache.addAll([
                '/TrainningAppV3/',
                '/TrainningAppV3/index.html',
                '/TrainningAppV3/_framework/blazor.webassembly.js',
                '/TrainningAppV3/manifest.json',
                // outros arquivos necessários
            ]);
        })
    );
});
