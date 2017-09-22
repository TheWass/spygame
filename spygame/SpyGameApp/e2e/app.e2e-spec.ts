import { SpyGameAppPage } from './app.po';

describe('spy-game-app App', () => {
  let page: SpyGameAppPage;

  beforeEach(() => {
    page = new SpyGameAppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
