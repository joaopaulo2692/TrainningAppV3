self.addEventListener('install', (event) => {
    event.waitUntil(
        caches.open('trainning-app-cache').then((cache) => {
            return cache.addAll([
                '/',
                '/index.html',
                '/css/app.css',
                '/_framework/blazor.webassembly.js',
                '/_framework/blazor.boot.json',
                '/images/icons/icon-192x192.png',
                '/images/icons/icon-512x512.png'
            ]);
        })
    );
});

self.addEventListener('fetch', (event) => {
    event.respondWith(
        caches.match(event.request).then((cachedResponse) => {
            return cachedResponse || fetch(event.request);
        })
    );
});
